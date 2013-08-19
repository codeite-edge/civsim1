using System.Collections.Generic;

namespace CivSim1.Lib.Resources
{
    public class Resource
    {
        public Resource(string signature, float mass, IEnumerable<Component> components)
        {
            Mass = mass;
        }

        public float Mass { get; set; }
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
        Wood
    }
}
