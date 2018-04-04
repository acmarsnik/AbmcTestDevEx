// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using AbmcTestDevEx.Models;
//
//    var empty = Empty.FromJson(jsonString);

namespace AbmcTestDevEx.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Empty
    {
        [JsonProperty("contributorItemDetails")]
        public List<ContributorItemDetail> ContributorItemDetails { get; set; }

        [JsonProperty("fittingCategory")]
        public FittingCategory FittingCategory { get; set; }

        [JsonProperty("fittingType")]
        public FittingType FittingType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("trimbleAssemblyItemId")]
        public object TrimbleAssemblyItemId { get; set; }

        [JsonProperty("trimbleItemId")]
        public string TrimbleItemId { get; set; }

        [JsonProperty("version")]
        public Version Version { get; set; }
    }

    public partial class ContributorItemDetail
    {
        [JsonProperty("connections")]
        public List<Connection> Connections { get; set; }

        [JsonProperty("contributorId")]
        public ContributorId ContributorId { get; set; }

        [JsonProperty("dimensions")]
        public List<Dimension> Dimensions { get; set; }

        [JsonProperty("itemChangeId")]
        public string ItemChangeId { get; set; }

        [JsonProperty("insulationThickness")]
        public long InsulationThickness { get; set; }

        [JsonProperty("insulationType")]
        public object InsulationType { get; set; }

        [JsonProperty("linerThickness")]
        public long LinerThickness { get; set; }

        [JsonProperty("linerType")]
        public object LinerType { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("modelChange")]
        public ModelChange ModelChange { get; set; }

        [JsonProperty("pricing")]
        public List<Pricing> Pricing { get; set; }

        [JsonProperty("properties")]
        public List<ContributorItemDetailProperty> Properties { get; set; }

        [JsonProperty("scopes")]
        public List<Scope> Scopes { get; set; }

        [JsonProperty("typeOfChange")]
        public TypeOfChange TypeOfChange { get; set; }

        [JsonProperty("units")]
        public Units Units { get; set; }
    }

    public partial class Connection
    {
        [JsonProperty("connectedTo")]
        public ConnectedTo ConnectedTo { get; set; }

        [JsonProperty("connectionDirection")]
        public ConnectionDirection ConnectionDirection { get; set; }

        [JsonProperty("connectionId")]
        public long ConnectionId { get; set; }

        [JsonProperty("connectionOtherDirection")]
        public ConnectionDirection ConnectionOtherDirection { get; set; }

        [JsonProperty("diameter")]
        public double Diameter { get; set; }

        [JsonProperty("discipline")]
        public Discipline Discipline { get; set; }

        [JsonProperty("flow")]
        public long Flow { get; set; }

        [JsonProperty("height")]
        public HeightUnion Height { get; set; }

        [JsonProperty("inset")]
        public long Inset { get; set; }

        [JsonProperty("isConnected")]
        public bool IsConnected { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("properties")]
        public List<ConnectionProperty> Properties { get; set; }

        [JsonProperty("shape")]
        public Shape Shape { get; set; }

        [JsonProperty("slope")]
        public long Slope { get; set; }

        [JsonProperty("system")]
        public ConnectionSystem? System { get; set; }

        [JsonProperty("width")]
        public HeightUnion Width { get; set; }
    }

    public partial class ConnectedTo
    {
        [JsonProperty("connectionId")]
        public long ConnectionId { get; set; }

        [JsonProperty("isConnected")]
        public bool IsConnected { get; set; }

        [JsonProperty("ParentTrimbleItemId")]
        public string ParentTrimbleItemId { get; set; }
    }

    public partial class ConnectionDirection
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("z")]
        public long Z { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }
    }

    public partial class ConnectionProperty
    {
        [JsonProperty("dataType")]
        public PurpleDataType DataType { get; set; }

        [JsonProperty("name")]
        public PropertyName Name { get; set; }

        [JsonProperty("value")]
        public FluffyValue Value { get; set; }
    }

    public partial class PurpleValue
    {
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }

        [JsonProperty("z", NullValueHandling = NullValueHandling.Ignore)]
        public double? Z { get; set; }

        [JsonProperty("connectionId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConnectionId { get; set; }

        [JsonProperty("isConnected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConnected { get; set; }

        [JsonProperty("parentTrimbleItemId")]
        public string ParentTrimbleItemId { get; set; }
    }

    public partial class Dimension
    {
        [JsonProperty("dataType")]
        public DimensionDataType DataType { get; set; }

        [JsonProperty("name")]
        public long Name { get; set; }

        [JsonProperty("value")]
        public DimensionValue Value { get; set; }
    }

    public partial class ModelChange
    {
        [JsonProperty("changeId")]
        public long ChangeId { get; set; }

        [JsonProperty("id")]
        public Id Id { get; set; }

        [JsonProperty("timeOfChange")]
        public System.DateTimeOffset TimeOfChange { get; set; }

        [JsonProperty("userSessionId")]
        public UserSessionId UserSessionId { get; set; }

        [JsonProperty("version")]
        public Version Version { get; set; }
    }

    public partial class Pricing
    {
        [JsonProperty("dataType")]
        public PricingDataType DataType { get; set; }

        [JsonProperty("name")]
        public PricingName Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class ContributorItemDetailProperty
    {
        [JsonProperty("dataType")]
        public FluffyDataType DataType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public TentacledValue Value { get; set; }
    }

    public partial class ValueElement
    {
        [JsonProperty("dataType")]
        public PricingDataType DataType { get; set; }

        [JsonProperty("name")]
        public NameUnion Name { get; set; }

        [JsonProperty("value")]
        public DimensionValue Value { get; set; }
    }

    public partial class Scope
    {
        [JsonProperty("dataType")]
        public ScopeDataType DataType { get; set; }

        [JsonProperty("name")]
        public long Name { get; set; }

        [JsonProperty("value")]
        public ScopeValue Value { get; set; }
    }

    public enum Discipline { Plumbing };

    public enum HeightEnum { NaN };

    public enum PurpleDataType { Boolean, ConnectedTo, Double, String, Vector, Xyz };

    public enum PropertyName { Angle, ConnectedTo, ConnectionDirection, ConnectionOtherDirection, Description, Diameter, Flow, FlowDirection, Height, Inset, IsConnected, IsMovable, IsUtilityConnector, Location, MepSystem, ParentTrimbleItemId, PressureDrop, Slope, System, VelocityPressure, Width };

    public enum Shape { Round };

    public enum ConnectionSystem { SupplyHydronic };

    public enum ContributorId { C199B9E302144161A60BCa8E0204D35B, The92D866Bb372642D6B232F7583058Deaf };

    public enum DimensionDataType { Double };

    public enum Id { Ecb1De6AC4064094826A0C517361C40C, The75E02Fe6309B454FBc02A8973853B9B1 };

    public enum UserSessionId { The504Abefa61A34760B6433Da3219B1B0D };

    public enum Version { The10 };

    public enum PricingDataType { Double, Int, String };

    public enum PricingName { DiscountMultiplier, PikcCode, Price, PriceCode, Quantity, TotalLaborCost, TotalLaborHours, UpcCode };

    public enum FluffyDataType { Bool, Double, IEnumerableIDimensionPropertyItem, IEnumerableIPricingPropertyItem, IEnumerableIScopePropertyItem, Int, Integer, String, Xyz };

    public enum ScopeDataType { String };

    public enum ScopeValue { CsButtWeld, Empty, Hhwr, Hhws, HydronicSupply, Level1 };

    public enum TypeOfChange { AddItemChange, ModifyItemChange };

    public enum Units { Feet };

    public enum FittingCategory { Fitting, Other, Straight };

    public enum FittingType { Elbow, Pipe, Tee, Undefined };

    public partial struct HeightUnion
    {
        public HeightEnum? Enum;
        public long? Integer;
    }

    public partial struct FluffyValue
    {
        public bool? Bool;
        public double? Double;
        public PurpleValue PurpleValue;
        public string String;
    }

    public partial struct DimensionValue
    {
        public double? Double;
        public string String;
    }

    public partial struct TentacledValue
    {
        public double? Double;
        public Location Location;
        public string String;
        public List<ValueElement> ValueElementArray;
    }

    public partial struct NameUnion
    {
        public PricingName? Enum;
        public long? Integer;
    }

    public partial class Empty
    {
        public static List<Empty> FromJson(string json) => JsonConvert.DeserializeObject<List<Empty>>(json, AbmcTestDevEx.Models.Converter.Settings);
    }

    static class DisciplineExtensions
    {
        public static Discipline? ValueForString(string str)
        {
            switch (str)
            {
                case "Plumbing": return Discipline.Plumbing;
                default: return null;
            }
        }

        public static Discipline ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Discipline value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Discipline.Plumbing: serializer.Serialize(writer, "Plumbing"); break;
            }
        }
    }

    static class HeightEnumExtensions
    {
        public static HeightEnum? ValueForString(string str)
        {
            switch (str)
            {
                case "NaN": return HeightEnum.NaN;
                default: return null;
            }
        }

        public static HeightEnum ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this HeightEnum value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case HeightEnum.NaN: serializer.Serialize(writer, "NaN"); break;
            }
        }
    }

    static class PurpleDataTypeExtensions
    {
        public static PurpleDataType? ValueForString(string str)
        {
            switch (str)
            {
                case "boolean": return PurpleDataType.Boolean;
                case "ConnectedTo": return PurpleDataType.ConnectedTo;
                case "double": return PurpleDataType.Double;
                case "string": return PurpleDataType.String;
                case "Vector": return PurpleDataType.Vector;
                case "Xyz": return PurpleDataType.Xyz;
                default: return null;
            }
        }

        public static PurpleDataType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PurpleDataType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case PurpleDataType.Boolean: serializer.Serialize(writer, "boolean"); break;
                case PurpleDataType.ConnectedTo: serializer.Serialize(writer, "ConnectedTo"); break;
                case PurpleDataType.Double: serializer.Serialize(writer, "double"); break;
                case PurpleDataType.String: serializer.Serialize(writer, "string"); break;
                case PurpleDataType.Vector: serializer.Serialize(writer, "Vector"); break;
                case PurpleDataType.Xyz: serializer.Serialize(writer, "Xyz"); break;
            }
        }
    }

    static class PropertyNameExtensions
    {
        public static PropertyName? ValueForString(string str)
        {
            switch (str)
            {
                case "Angle": return PropertyName.Angle;
                case "ConnectedTo": return PropertyName.ConnectedTo;
                case "ConnectionDirection": return PropertyName.ConnectionDirection;
                case "ConnectionOtherDirection": return PropertyName.ConnectionOtherDirection;
                case "Description": return PropertyName.Description;
                case "Diameter": return PropertyName.Diameter;
                case "Flow": return PropertyName.Flow;
                case "FlowDirection": return PropertyName.FlowDirection;
                case "Height": return PropertyName.Height;
                case "Inset": return PropertyName.Inset;
                case "IsConnected": return PropertyName.IsConnected;
                case "IsMovable": return PropertyName.IsMovable;
                case "IsUtilityConnector": return PropertyName.IsUtilityConnector;
                case "Location": return PropertyName.Location;
                case "MEPSystem": return PropertyName.MepSystem;
                case "ParentTrimbleItemId": return PropertyName.ParentTrimbleItemId;
                case "PressureDrop": return PropertyName.PressureDrop;
                case "Slope": return PropertyName.Slope;
                case "System": return PropertyName.System;
                case "VelocityPressure": return PropertyName.VelocityPressure;
                case "Width": return PropertyName.Width;
                default: return null;
            }
        }

        public static PropertyName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PropertyName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case PropertyName.Angle: serializer.Serialize(writer, "Angle"); break;
                case PropertyName.ConnectedTo: serializer.Serialize(writer, "ConnectedTo"); break;
                case PropertyName.ConnectionDirection: serializer.Serialize(writer, "ConnectionDirection"); break;
                case PropertyName.ConnectionOtherDirection: serializer.Serialize(writer, "ConnectionOtherDirection"); break;
                case PropertyName.Description: serializer.Serialize(writer, "Description"); break;
                case PropertyName.Diameter: serializer.Serialize(writer, "Diameter"); break;
                case PropertyName.Flow: serializer.Serialize(writer, "Flow"); break;
                case PropertyName.FlowDirection: serializer.Serialize(writer, "FlowDirection"); break;
                case PropertyName.Height: serializer.Serialize(writer, "Height"); break;
                case PropertyName.Inset: serializer.Serialize(writer, "Inset"); break;
                case PropertyName.IsConnected: serializer.Serialize(writer, "IsConnected"); break;
                case PropertyName.IsMovable: serializer.Serialize(writer, "IsMovable"); break;
                case PropertyName.IsUtilityConnector: serializer.Serialize(writer, "IsUtilityConnector"); break;
                case PropertyName.Location: serializer.Serialize(writer, "Location"); break;
                case PropertyName.MepSystem: serializer.Serialize(writer, "MEPSystem"); break;
                case PropertyName.ParentTrimbleItemId: serializer.Serialize(writer, "ParentTrimbleItemId"); break;
                case PropertyName.PressureDrop: serializer.Serialize(writer, "PressureDrop"); break;
                case PropertyName.Slope: serializer.Serialize(writer, "Slope"); break;
                case PropertyName.System: serializer.Serialize(writer, "System"); break;
                case PropertyName.VelocityPressure: serializer.Serialize(writer, "VelocityPressure"); break;
                case PropertyName.Width: serializer.Serialize(writer, "Width"); break;
            }
        }
    }

    static class ShapeExtensions
    {
        public static Shape? ValueForString(string str)
        {
            switch (str)
            {
                case "Round": return Shape.Round;
                default: return null;
            }
        }

        public static Shape ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Shape value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Shape.Round: serializer.Serialize(writer, "Round"); break;
            }
        }
    }

    static class ConnectionSystemExtensions
    {
        public static ConnectionSystem? ValueForString(string str)
        {
            switch (str)
            {
                case "SupplyHydronic": return ConnectionSystem.SupplyHydronic;
                default: return null;
            }
        }

        public static ConnectionSystem ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ConnectionSystem value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ConnectionSystem.SupplyHydronic: serializer.Serialize(writer, "SupplyHydronic"); break;
            }
        }
    }

    static class ContributorIdExtensions
    {
        public static ContributorId? ValueForString(string str)
        {
            switch (str)
            {
                case "c199b9e3-0214-4161-a60b-ca8e0204d35b": return ContributorId.C199B9E302144161A60BCa8E0204D35B;
                case "92d866bb-3726-42d6-b232-f7583058deaf": return ContributorId.The92D866Bb372642D6B232F7583058Deaf;
                default: return null;
            }
        }

        public static ContributorId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ContributorId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ContributorId.C199B9E302144161A60BCa8E0204D35B: serializer.Serialize(writer, "c199b9e3-0214-4161-a60b-ca8e0204d35b"); break;
                case ContributorId.The92D866Bb372642D6B232F7583058Deaf: serializer.Serialize(writer, "92d866bb-3726-42d6-b232-f7583058deaf"); break;
            }
        }
    }

    static class DimensionDataTypeExtensions
    {
        public static DimensionDataType? ValueForString(string str)
        {
            switch (str)
            {
                case "double": return DimensionDataType.Double;
                default: return null;
            }
        }

        public static DimensionDataType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this DimensionDataType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case DimensionDataType.Double: serializer.Serialize(writer, "double"); break;
            }
        }
    }

    static class IdExtensions
    {
        public static Id? ValueForString(string str)
        {
            switch (str)
            {
                case "ecb1de6a-c406-4094-826a-0c517361c40c": return Id.Ecb1De6AC4064094826A0C517361C40C;
                case "75e02fe6-309b-454f-bc02-a8973853b9b1": return Id.The75E02Fe6309B454FBc02A8973853B9B1;
                default: return null;
            }
        }

        public static Id ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Id value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Id.Ecb1De6AC4064094826A0C517361C40C: serializer.Serialize(writer, "ecb1de6a-c406-4094-826a-0c517361c40c"); break;
                case Id.The75E02Fe6309B454FBc02A8973853B9B1: serializer.Serialize(writer, "75e02fe6-309b-454f-bc02-a8973853b9b1"); break;
            }
        }
    }

    static class UserSessionIdExtensions
    {
        public static UserSessionId? ValueForString(string str)
        {
            switch (str)
            {
                case "504abefa-61a3-4760-b643-3da3219b1b0d": return UserSessionId.The504Abefa61A34760B6433Da3219B1B0D;
                default: return null;
            }
        }

        public static UserSessionId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this UserSessionId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case UserSessionId.The504Abefa61A34760B6433Da3219B1B0D: serializer.Serialize(writer, "504abefa-61a3-4760-b643-3da3219b1b0d"); break;
            }
        }
    }

    static class VersionExtensions
    {
        public static Version? ValueForString(string str)
        {
            switch (str)
            {
                case "1.0": return Version.The10;
                default: return null;
            }
        }

        public static Version ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Version value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Version.The10: serializer.Serialize(writer, "1.0"); break;
            }
        }
    }

    static class PricingDataTypeExtensions
    {
        public static PricingDataType? ValueForString(string str)
        {
            switch (str)
            {
                case "double": return PricingDataType.Double;
                case "int": return PricingDataType.Int;
                case "string": return PricingDataType.String;
                default: return null;
            }
        }

        public static PricingDataType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PricingDataType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case PricingDataType.Double: serializer.Serialize(writer, "double"); break;
                case PricingDataType.Int: serializer.Serialize(writer, "int"); break;
                case PricingDataType.String: serializer.Serialize(writer, "string"); break;
            }
        }
    }

    static class PricingNameExtensions
    {
        public static PricingName? ValueForString(string str)
        {
            switch (str)
            {
                case "DiscountMultiplier": return PricingName.DiscountMultiplier;
                case "PikcCode": return PricingName.PikcCode;
                case "Price": return PricingName.Price;
                case "PriceCode": return PricingName.PriceCode;
                case "Quantity": return PricingName.Quantity;
                case "TotalLaborCost": return PricingName.TotalLaborCost;
                case "TotalLaborHours": return PricingName.TotalLaborHours;
                case "UpcCode": return PricingName.UpcCode;
                default: return null;
            }
        }

        public static PricingName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PricingName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case PricingName.DiscountMultiplier: serializer.Serialize(writer, "DiscountMultiplier"); break;
                case PricingName.PikcCode: serializer.Serialize(writer, "PikcCode"); break;
                case PricingName.Price: serializer.Serialize(writer, "Price"); break;
                case PricingName.PriceCode: serializer.Serialize(writer, "PriceCode"); break;
                case PricingName.Quantity: serializer.Serialize(writer, "Quantity"); break;
                case PricingName.TotalLaborCost: serializer.Serialize(writer, "TotalLaborCost"); break;
                case PricingName.TotalLaborHours: serializer.Serialize(writer, "TotalLaborHours"); break;
                case PricingName.UpcCode: serializer.Serialize(writer, "UpcCode"); break;
            }
        }
    }

    static class FluffyDataTypeExtensions
    {
        public static FluffyDataType? ValueForString(string str)
        {
            switch (str)
            {
                case "bool": return FluffyDataType.Bool;
                case "double": return FluffyDataType.Double;
                case "IEnumerable<IDimensionPropertyItem>": return FluffyDataType.IEnumerableIDimensionPropertyItem;
                case "IEnumerable<IPricingPropertyItem>": return FluffyDataType.IEnumerableIPricingPropertyItem;
                case "IEnumerable<IScopePropertyItem>": return FluffyDataType.IEnumerableIScopePropertyItem;
                case "int": return FluffyDataType.Int;
                case "integer": return FluffyDataType.Integer;
                case "string": return FluffyDataType.String;
                case "Xyz": return FluffyDataType.Xyz;
                default: return null;
            }
        }

        public static FluffyDataType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this FluffyDataType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case FluffyDataType.Bool: serializer.Serialize(writer, "bool"); break;
                case FluffyDataType.Double: serializer.Serialize(writer, "double"); break;
                case FluffyDataType.IEnumerableIDimensionPropertyItem: serializer.Serialize(writer, "IEnumerable<IDimensionPropertyItem>"); break;
                case FluffyDataType.IEnumerableIPricingPropertyItem: serializer.Serialize(writer, "IEnumerable<IPricingPropertyItem>"); break;
                case FluffyDataType.IEnumerableIScopePropertyItem: serializer.Serialize(writer, "IEnumerable<IScopePropertyItem>"); break;
                case FluffyDataType.Int: serializer.Serialize(writer, "int"); break;
                case FluffyDataType.Integer: serializer.Serialize(writer, "integer"); break;
                case FluffyDataType.String: serializer.Serialize(writer, "string"); break;
                case FluffyDataType.Xyz: serializer.Serialize(writer, "Xyz"); break;
            }
        }
    }

    static class ScopeDataTypeExtensions
    {
        public static ScopeDataType? ValueForString(string str)
        {
            switch (str)
            {
                case "string": return ScopeDataType.String;
                default: return null;
            }
        }

        public static ScopeDataType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ScopeDataType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ScopeDataType.String: serializer.Serialize(writer, "string"); break;
            }
        }
    }

    static class ScopeValueExtensions
    {
        public static ScopeValue? ValueForString(string str)
        {
            switch (str)
            {
                case "CS Butt Weld": return ScopeValue.CsButtWeld;
                case "": return ScopeValue.Empty;
                case "HHWR": return ScopeValue.Hhwr;
                case "HHWS": return ScopeValue.Hhws;
                case "Hydronic Supply": return ScopeValue.HydronicSupply;
                case "Level 1": return ScopeValue.Level1;
                default: return null;
            }
        }

        public static ScopeValue ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ScopeValue value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ScopeValue.CsButtWeld: serializer.Serialize(writer, "CS Butt Weld"); break;
                case ScopeValue.Empty: serializer.Serialize(writer, ""); break;
                case ScopeValue.Hhwr: serializer.Serialize(writer, "HHWR"); break;
                case ScopeValue.Hhws: serializer.Serialize(writer, "HHWS"); break;
                case ScopeValue.HydronicSupply: serializer.Serialize(writer, "Hydronic Supply"); break;
                case ScopeValue.Level1: serializer.Serialize(writer, "Level 1"); break;
            }
        }
    }

    static class TypeOfChangeExtensions
    {
        public static TypeOfChange? ValueForString(string str)
        {
            switch (str)
            {
                case "AddItemChange": return TypeOfChange.AddItemChange;
                case "ModifyItemChange": return TypeOfChange.ModifyItemChange;
                default: return null;
            }
        }

        public static TypeOfChange ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this TypeOfChange value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case TypeOfChange.AddItemChange: serializer.Serialize(writer, "AddItemChange"); break;
                case TypeOfChange.ModifyItemChange: serializer.Serialize(writer, "ModifyItemChange"); break;
            }
        }
    }

    static class UnitsExtensions
    {
        public static Units? ValueForString(string str)
        {
            switch (str)
            {
                case "Feet": return Units.Feet;
                default: return null;
            }
        }

        public static Units ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Units value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Units.Feet: serializer.Serialize(writer, "Feet"); break;
            }
        }
    }

    static class FittingCategoryExtensions
    {
        public static FittingCategory? ValueForString(string str)
        {
            switch (str)
            {
                case "Fitting": return FittingCategory.Fitting;
                case "Other": return FittingCategory.Other;
                case "Straight": return FittingCategory.Straight;
                default: return null;
            }
        }

        public static FittingCategory ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this FittingCategory value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case FittingCategory.Fitting: serializer.Serialize(writer, "Fitting"); break;
                case FittingCategory.Other: serializer.Serialize(writer, "Other"); break;
                case FittingCategory.Straight: serializer.Serialize(writer, "Straight"); break;
            }
        }
    }

    static class FittingTypeExtensions
    {
        public static FittingType? ValueForString(string str)
        {
            switch (str)
            {
                case "Elbow": return FittingType.Elbow;
                case "Pipe": return FittingType.Pipe;
                case "Tee": return FittingType.Tee;
                case "Undefined": return FittingType.Undefined;
                default: return null;
            }
        }

        public static FittingType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this FittingType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case FittingType.Elbow: serializer.Serialize(writer, "Elbow"); break;
                case FittingType.Pipe: serializer.Serialize(writer, "Pipe"); break;
                case FittingType.Tee: serializer.Serialize(writer, "Tee"); break;
                case FittingType.Undefined: serializer.Serialize(writer, "Undefined"); break;
            }
        }
    }

    public partial struct HeightUnion
    {
        public HeightUnion(JsonReader reader, JsonSerializer serializer)
        {
            Enum = null;
            Integer = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    Enum = serializer.Deserialize<HeightEnum>(reader);
                    return;
            }
            throw new Exception("Cannot convert HeightUnion");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Enum != null)
            {
                serializer.Serialize(writer, Enum);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct FluffyValue
    {
        public FluffyValue(JsonReader reader, JsonSerializer serializer)
        {
            Bool = null;
            Double = null;
            PurpleValue = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    Double = serializer.Deserialize<double>(reader);
                    return;
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.StartObject:
                    PurpleValue = serializer.Deserialize<PurpleValue>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert FluffyValue");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (Double != null)
            {
                serializer.Serialize(writer, Double);
                return;
            }
            if (PurpleValue != null)
            {
                serializer.Serialize(writer, PurpleValue);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct DimensionValue
    {
        public DimensionValue(JsonReader reader, JsonSerializer serializer)
        {
            Double = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    Double = serializer.Deserialize<double>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert DimensionValue");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Double != null)
            {
                serializer.Serialize(writer, Double);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct TentacledValue
    {
        public TentacledValue(JsonReader reader, JsonSerializer serializer)
        {
            Double = null;
            Location = null;
            String = null;
            ValueElementArray = null;

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return;
                case JsonToken.Integer:
                case JsonToken.Float:
                    Double = serializer.Deserialize<double>(reader);
                    return;
                case JsonToken.StartArray:
                    ValueElementArray = serializer.Deserialize<List<ValueElement>>(reader);
                    return;
                case JsonToken.StartObject:
                    Location = serializer.Deserialize<Location>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert TentacledValue");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Double != null)
            {
                serializer.Serialize(writer, Double);
                return;
            }
            if (Location != null)
            {
                serializer.Serialize(writer, Location);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            if (ValueElementArray != null)
            {
                serializer.Serialize(writer, ValueElementArray);
                return;
            }
            writer.WriteNull();
        }
    }

    public partial struct NameUnion
    {
        public NameUnion(JsonReader reader, JsonSerializer serializer)
        {
            Enum = null;
            Integer = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    Enum = serializer.Deserialize<PricingName>(reader);
                    return;
            }
            throw new Exception("Cannot convert NameUnion");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Enum != null)
            {
                serializer.Serialize(writer, Enum);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public static class Serialize
    {
        public static string ToJson(this List<Empty> self) => JsonConvert.SerializeObject(self, AbmcTestDevEx.Models.Converter.Settings);
    }

    internal class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Discipline) || t == typeof(HeightEnum) || t == typeof(PurpleDataType) || t == typeof(PropertyName) || t == typeof(Shape) || t == typeof(ConnectionSystem) || t == typeof(ContributorId) || t == typeof(DimensionDataType) || t == typeof(Id) || t == typeof(UserSessionId) || t == typeof(Version) || t == typeof(PricingDataType) || t == typeof(PricingName) || t == typeof(FluffyDataType) || t == typeof(ScopeDataType) || t == typeof(ScopeValue) || t == typeof(TypeOfChange) || t == typeof(Units) || t == typeof(FittingCategory) || t == typeof(FittingType) || t == typeof(HeightUnion) || t == typeof(FluffyValue) || t == typeof(DimensionValue) || t == typeof(TentacledValue) || t == typeof(NameUnion) || t == typeof(Discipline?) || t == typeof(HeightEnum?) || t == typeof(PurpleDataType?) || t == typeof(PropertyName?) || t == typeof(Shape?) || t == typeof(ConnectionSystem?) || t == typeof(ContributorId?) || t == typeof(DimensionDataType?) || t == typeof(Id?) || t == typeof(UserSessionId?) || t == typeof(Version?) || t == typeof(PricingDataType?) || t == typeof(PricingName?) || t == typeof(FluffyDataType?) || t == typeof(ScopeDataType?) || t == typeof(ScopeValue?) || t == typeof(TypeOfChange?) || t == typeof(Units?) || t == typeof(FittingCategory?) || t == typeof(FittingType?) || t == typeof(HeightUnion?) || t == typeof(FluffyValue?) || t == typeof(DimensionValue?) || t == typeof(TentacledValue?) || t == typeof(NameUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Discipline))
                return DisciplineExtensions.ReadJson(reader, serializer);
            if (t == typeof(HeightEnum))
                return HeightEnumExtensions.ReadJson(reader, serializer);
            if (t == typeof(PurpleDataType))
                return PurpleDataTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(PropertyName))
                return PropertyNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(Shape))
                return ShapeExtensions.ReadJson(reader, serializer);
            if (t == typeof(ConnectionSystem))
                return ConnectionSystemExtensions.ReadJson(reader, serializer);
            if (t == typeof(ContributorId))
                return ContributorIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(DimensionDataType))
                return DimensionDataTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Id))
                return IdExtensions.ReadJson(reader, serializer);
            if (t == typeof(UserSessionId))
                return UserSessionIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(Version))
                return VersionExtensions.ReadJson(reader, serializer);
            if (t == typeof(PricingDataType))
                return PricingDataTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(PricingName))
                return PricingNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(FluffyDataType))
                return FluffyDataTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(ScopeDataType))
                return ScopeDataTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(ScopeValue))
                return ScopeValueExtensions.ReadJson(reader, serializer);
            if (t == typeof(TypeOfChange))
                return TypeOfChangeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Units))
                return UnitsExtensions.ReadJson(reader, serializer);
            if (t == typeof(FittingCategory))
                return FittingCategoryExtensions.ReadJson(reader, serializer);
            if (t == typeof(FittingType))
                return FittingTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Discipline?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DisciplineExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(HeightEnum?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return HeightEnumExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(PurpleDataType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PurpleDataTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(PropertyName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PropertyNameExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Shape?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ShapeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ConnectionSystem?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ConnectionSystemExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ContributorId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ContributorIdExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(DimensionDataType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DimensionDataTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Id?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return IdExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(UserSessionId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return UserSessionIdExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Version?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return VersionExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(PricingDataType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PricingDataTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(PricingName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PricingNameExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(FluffyDataType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return FluffyDataTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ScopeDataType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ScopeDataTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ScopeValue?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ScopeValueExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(TypeOfChange?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return TypeOfChangeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Units?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return UnitsExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(FittingCategory?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return FittingCategoryExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(FittingType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return FittingTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(HeightUnion) || t == typeof(HeightUnion?))
                return new HeightUnion(reader, serializer);
            if (t == typeof(FluffyValue) || t == typeof(FluffyValue?))
                return new FluffyValue(reader, serializer);
            if (t == typeof(DimensionValue) || t == typeof(DimensionValue?))
                return new DimensionValue(reader, serializer);
            if (t == typeof(TentacledValue) || t == typeof(TentacledValue?))
                return new TentacledValue(reader, serializer);
            if (t == typeof(NameUnion) || t == typeof(NameUnion?))
                return new NameUnion(reader, serializer);
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(Discipline))
            {
                ((Discipline)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(HeightEnum))
            {
                ((HeightEnum)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(PurpleDataType))
            {
                ((PurpleDataType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(PropertyName))
            {
                ((PropertyName)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Shape))
            {
                ((Shape)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ConnectionSystem))
            {
                ((ConnectionSystem)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ContributorId))
            {
                ((ContributorId)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(DimensionDataType))
            {
                ((DimensionDataType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Id))
            {
                ((Id)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(UserSessionId))
            {
                ((UserSessionId)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Version))
            {
                ((Version)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(PricingDataType))
            {
                ((PricingDataType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(PricingName))
            {
                ((PricingName)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(FluffyDataType))
            {
                ((FluffyDataType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ScopeDataType))
            {
                ((ScopeDataType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ScopeValue))
            {
                ((ScopeValue)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(TypeOfChange))
            {
                ((TypeOfChange)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Units))
            {
                ((Units)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(FittingCategory))
            {
                ((FittingCategory)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(FittingType))
            {
                ((FittingType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(HeightUnion))
            {
                ((HeightUnion)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(FluffyValue))
            {
                ((FluffyValue)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(DimensionValue))
            {
                ((DimensionValue)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(TentacledValue))
            {
                ((TentacledValue)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(NameUnion))
            {
                ((NameUnion)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new Converter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

