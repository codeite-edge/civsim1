using System.Collections.Generic;
using System.Linq;
using CivSim1.Lib.Resources;

namespace CivSim1.Lib.World
{
    public class Tile
    {
        private readonly List<Resource> _resources = new List<Resource>();

        public void AddResource(Resource resource)
        {
            if (resource == null)
            {
                return;
            }

                _resources.Add(resource);
            
        }

        public T GetResourceAgrigate<T>(T instance) where T : Resource
        {
            var amount = _resources.OfType<T>().Sum(x => x.Mass);
            instance.Mass = amount;
            return instance;
        }
    }
}