namespace CivSim1.Lib.Resources
{
    public static class StoneResourceFactory
    {
        public const string Granite = "Granite";

        public static Resource MakeGranite(float mass)
        {
            return new Resource(Granite,
                                mass,
                                new[]
                                {
                                    new Component {ComponentType = ComponentType.Silica, Mass = mass * 0.8f},
                                    new Component {ComponentType = ComponentType.Quartz, Mass = mass * 0.2f}
                                });
        }
    }
}