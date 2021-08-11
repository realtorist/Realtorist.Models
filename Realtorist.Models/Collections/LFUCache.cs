using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Realtorist.Models.Collections
{
    public class LFUCache<T, V> : IDictionary<T, V>
    {
        private readonly int _capacity;
        private readonly Dictionary<T, V> _values = new Dictionary<T, V>();

        private readonly Dictionary<int, LinkedList<T>> _frequencies = new Dictionary<int, LinkedList<T>>();
        private readonly Dictionary<T, (int, LinkedListNode<T>)> _opFrequencies = new Dictionary<T, (int, LinkedListNode<T>)>();

        private int _minFrequency = 1;

        public LFUCache(int capacity)
        {
            _capacity = capacity;
        }

        public V this[T key] { get => Get(key); set => Add(key, value); }

        public ICollection<T> Keys => _values.Keys;

        public ICollection<V> Values => _values.Values;

        public int Count => _values.Count;

        public bool IsReadOnly => false;

        public void Clear()
        {
            _values.Clear();
            _frequencies.Clear();
            _opFrequencies.Clear();

            _minFrequency = 1;
        }

        public bool Contains(KeyValuePair<T, V> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(T key)
        {
            return _values.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<T, V>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public V Get(T key)
        {
            if (!_values.ContainsKey(key)) throw new KeyNotFoundException($"Key {key} wasn't found");

            UpdateFrequencies(key);

            return _values[key];
        }

        public IEnumerator<KeyValuePair<T, V>> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        public void Add(KeyValuePair<T, V> item)
        {
            Add(item.Key, item.Value);
        }

        public void Add(T key, V value)
        {
            if (_capacity == 0) return;
            if (_values.ContainsKey(key))
            {
                UpdateFrequencies(key);
                _values[key] = value;

                return;
            }

            if (_values.Count >= _capacity)
            {
                var smallestFreq = _minFrequency;
                var keyToEvict = _frequencies[smallestFreq].First();
                _frequencies[smallestFreq].RemoveFirst();
                if (_frequencies[smallestFreq].Count == 0) _frequencies.Remove(smallestFreq);
                _opFrequencies.Remove(keyToEvict);
                _values.Remove(keyToEvict);
            }

            _values[key] = value;
            if (!_frequencies.ContainsKey(1)) _frequencies[1] = new LinkedList<T>();
            var node = _frequencies[1].AddLast(key);
            _opFrequencies[key] = (1, node);

            _minFrequency = 1;
        }

        public bool Remove(T key)
        {
            if (!_values.ContainsKey(key)) return false;

            var freq = _opFrequencies[key];
            _frequencies[freq.Item1].Remove(freq.Item2);

            if (_frequencies[freq.Item1].Count == 0)
            {
                _frequencies.Remove(freq.Item1);
                if (freq.Item1 == _minFrequency) _minFrequency = _frequencies.Count == 0 ? 1 : _frequencies.Keys.Min();
            }

            return _opFrequencies.Remove(key);
        }

        public bool Remove(KeyValuePair<T, V> item)
        {
            return _values.ContainsKey(item.Key) && _values[item.Key].Equals(item.Value)
                ? Remove(item.Key)
                : false;
        }

        public bool TryGetValue(T key, [MaybeNullWhen(false)] out V value)
        {
            return _values.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        private void UpdateFrequencies(T key)
        {
            var freq = _opFrequencies[key];
            _frequencies[freq.Item1].Remove(freq.Item2);

            var newFreq = freq.Item1 + 1;
            if (!_frequencies.ContainsKey(newFreq)) _frequencies[newFreq] = new LinkedList<T>();

            if (_frequencies[freq.Item1].Count == 0)
            {
                _frequencies.Remove(freq.Item1);
                if (freq.Item1 == _minFrequency) _minFrequency = newFreq;
            }

            var node = _frequencies[newFreq].AddLast(key);
            _opFrequencies[key] = (newFreq, node);
        }
    }
}
