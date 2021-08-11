using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Realtorist.Models.Settings.Appearance.Theme
{
    public class PageComponent
    {
        public string Type { get; set; }

        public Dictionary<string, JToken> Values { get; set; }
    }
}