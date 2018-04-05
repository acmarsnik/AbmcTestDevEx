using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbmcTestDevEx.Models
{
    public class AbmcAsIs
    {
        public class Location
        {
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }
        }

        public class ModelChange
        {
            public int changeId { get; set; }
            public string id { get; set; }
            public DateTime timeOfChange { get; set; }
            public string userSessionId { get; set; }
            public string version { get; set; }
        }

        public class Property
        {
            public string dataType { get; set; }
            public string name { get; set; }
            public object value { get; set; }
        }

        public class Scope
        {
            public string dataType { get; set; }
            public int name { get; set; }
            public string value { get; set; }
        }

        public class ContributorItemDetail
        {
            public List<object> connections { get; set; }
            public string contributorId { get; set; }
            public List<object> dimensions { get; set; }
            public string itemChangeId { get; set; }
            public int insulationThickness { get; set; }
            public object insulationType { get; set; }
            public int linerThickness { get; set; }
            public object linerType { get; set; }
            public Location location { get; set; }
            public ModelChange modelChange { get; set; }
            public List<object> pricing { get; set; }
            public List<Property> properties { get; set; }
            public List<Scope> scopes { get; set; }
            public string typeOfChange { get; set; }
            public string units { get; set; }
        }

        public class RootObject
        {
            public List<ContributorItemDetail> contributorItemDetails { get; set; }
            public string fittingCategory { get; set; }
            public string fittingType { get; set; }
            public string name { get; set; }
            public object trimbleAssemblyItemId { get; set; }
            public string trimbleItemId { get; set; }
            public string version { get; set; }
        }
    }
}
