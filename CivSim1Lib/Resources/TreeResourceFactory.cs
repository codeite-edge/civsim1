namespace CivSim1.Lib.Resources
{
    static class TreeResourceFactory
    {
        public const string Pine = "Pine";
        public const string Oak = "Oak";

        public static Resource MakePineTree(float mass)
        {
            return new Resource("Pine",
                                mass,
                                new[]
                                {
                                    new Component {ComponentType = ComponentType.SoftWood, Mass = mass}
                                });
        }

        public static Resource MakeOakTree(float mass)
        {
            return new Resource("Oak",
                                mass,
                                new[]
                                {
                                    new Component {ComponentType = ComponentType.HardWood, Mass = mass}
                                });
        }
    }
}