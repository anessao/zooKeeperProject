using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zooWorld.DataModels
{
    public class Environment
    {
        public int Id { get; set; }
        public bool ProductPlacement { get; set; }
        public bool WaterFeature { get; set; }
        public int MaxOccupancy { get; set; }
        public DateTime DateCreated { get; set; }
        public ZooZoneType Type { get; set; }
    }
    public enum ZooZoneType
    {
        Africa,
        Asia,
        NorthAmerica,
        SouthAmerica
    }

}