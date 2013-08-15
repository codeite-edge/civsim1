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

            var type = resource.GetType();

            var existingResource = _resources.SingleOrDefault(x => x.GetType() == type);

            if (existingResource == null)
            {
                _resources.Add(resource);
            }
            else
            {
                existingResource.Amount += resource.Amount;
            }
        }

        public T GetResourceAgrigate<T>(T instance) where T : Resource
        {
            var amount = _resources.OfType<T>().Sum(x => x.Amount);
            instance.Amount = amount;
            return instance;
        }
    }
}