using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CivSim1.Lib.Resources
{
    static class TreeResourceFactory
    {
        public static Resource MakeRedBerries(float mass)
        {
            return new Resource("RedBerry",
                                mass,
                                new[]
                                {
                                    new Component {ComponentType = ComponentType.Wood, Mass = mass}
                                });
        }
    }

    static class FoodResourceFactory
    {
        public static Resource MakeRedBerries(float mass)
        {
            return new Resource("RedBerry",
                                mass,
                                new[]
                                {
                                    new Component {ComponentType = ComponentType.Carbohydrate, Mass = mass*0.4f},
                                    new Component {ComponentType = ComponentType.Sugars, Mass = mass*0.4f},
                                    new Component {ComponentType = ComponentType.Fiber, Mass = mass*0.18f},
                                    new Component {ComponentType = ComponentType.VitaminA, Mass = mass*0.02f},
                                });
        }

        public static Resource MakeYellowBerries(float mass)
        {
            return new Resource("YellowBerry",
                                mass,
                                new[]
                                {
                                    new Component {ComponentType = ComponentType.Carbohydrate, Mass = mass*0.6f},
                                    new Component {ComponentType = ComponentType.Sugars, Mass = mass*0.2f},
                                    new Component {ComponentType = ComponentType.Fiber, Mass = mass*0.18f},
                                    new Component {ComponentType = ComponentType.VitaminB, Mass = mass*0.02f},
                                });
        }

        public static Resource MakeNuts(float mass)
        {
            return new Resource("HazelNut",
                                mass,
                                new[]
                                {
                                    new Component {ComponentType = ComponentType.Carbohydrate, Mass = mass*0.2f},
                                    new Component {ComponentType = ComponentType.Sugars, Mass = mass*0.1f},
                                    new Component {ComponentType = ComponentType.Protien, Mass = mass*0.5f},
                                    new Component {ComponentType = ComponentType.Fiber, Mass = mass*0.1f},
                                });
        }
    }
}
