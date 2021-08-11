using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum CommunicationType
    {
		[Display(Name = "Internet Access")]
		[XmlEnum(Name = "Internet Access")]
		Internet_Access = 1,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 17,

		[Display(Name = "WAN")]
		[XmlEnum(Name = "WAN")]
		WAN = 16,

		[Display(Name = "LAN")]
		[XmlEnum(Name = "LAN")]
		LAN = 15,

		[Display(Name = "Firewall")]
		[XmlEnum(Name = "Firewall")]
		Firewall = 14,

		[Display(Name = "ISDN access")]
		[XmlEnum(Name = "ISDN access")]
		ISDN_access = 13,

		[Display(Name = "Cable Internet access")]
		[XmlEnum(Name = "Cable Internet access")]
		Cable_Internet_access = 12,

		[Display(Name = "satellite Internet access")]
		[XmlEnum(Name = "satellite Internet access")]
		satellite_Internet_access = 11,

		[Display(Name = "High Speed Internet")]
		[XmlEnum(Name = "High Speed Internet")]
		High_Speed_Internet = 18,

		[Display(Name = "Switches")]
		[XmlEnum(Name = "Switches")]
		Switches = 10,

		[Display(Name = "PC")]
		[XmlEnum(Name = "PC")]
		PC = 8,

		[Display(Name = "Servers")]
		[XmlEnum(Name = "Servers")]
		Servers = 7,

		[Display(Name = "Server Racks")]
		[XmlEnum(Name = "Server Racks")]
		Server_Racks = 6,

		[Display(Name = "Climate controlled server room")]
		[XmlEnum(Name = "Climate controlled server room")]
		Climate_controlled_server_room = 5,

		[Display(Name = "Modem")]
		[XmlEnum(Name = "Modem")]
		Modem = 4,

		[Display(Name = "DSL")]
		[XmlEnum(Name = "DSL")]
		DSL = 3,

		[Display(Name = "Patch Panel")]
		[XmlEnum(Name = "Patch Panel")]
		Patch_Panel = 2,

		[Display(Name = "Routers")]
		[XmlEnum(Name = "Routers")]
		Routers = 9,

		[Display(Name = "Fiber")]
		[XmlEnum(Name = "Fiber")]
		Fiber = 19
    }
}