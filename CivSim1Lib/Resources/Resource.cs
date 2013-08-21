using System.Collections.Generic;

namespace CivSim1.Lib.Resources
{
    public class Resource
    {
        private readonly string _signature;

        public Resource(string signature, float mass, IEnumerable<Component> components)
        {
            Mass = mass;
            _signature = signature;
        }

        public float Mass { get; set; }

        public string Signature
        {
            get { return _signature; }
        }
    }

    public struct Component
    {
        public ComponentType ComponentType;
        public float Mass;
    }

    public enum ComponentType
    {
        Protien,
        Carbohydrate,
        Sugars,
        Fat,
        Fiber,
        Sodium,
        VitaminA,
        VitaminB,
        VitaminC,
        HardWood,
        SoftWood,
        Silica,
        Quartz,
        Iron,
        Aluminium,
        Tin,
        Copper,
    }
}
