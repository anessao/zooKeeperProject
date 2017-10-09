using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zooWorld.DataModels
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public SpeciesType SpeciesType { get; set; }
        public bool TasteForBlood { get; set; }
        public SkinType SkinType { get; set; }


        public virtual ZooKeeper ZooKeeper { get; set; }
        public virtual Environment Environment { get; set; }
    }
    public enum SpeciesType
    {
        Reptile,
        Mammal,
        Insect
    }
    public enum SkinType
    {
        Fur,
        Scale,
        Feather
    }
}