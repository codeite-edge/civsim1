using CivSim1.Lib.World;

namespace CivSim1.Lib.Entities
{
    public abstract class Entity
    {
        public abstract void Tick(Zone zone);
    }
}