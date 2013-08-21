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

            var existing = _resources.FirstOrDefault(x => x.Signature == resource.Signature);
            
            if (existing != null)
            {
                existing.Mass += resource.Mass;
            }
            else
            {
                _resources.Add(resource);
            }
            
        }

        public T GetResourceAgrigate<T>(T instance) where T : Resource
        {
            var amount = _resources.OfType<T>().Sum(x => x.Mass);
            instance.Mass = amount;
            return instance;
        }

        public Resource GetResourceWithSignature(string signature)
        {
            return _resources.FirstOrDefault(x => x.Signature == signature);
        }
    }
}