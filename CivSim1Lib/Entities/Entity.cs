using CivSim1Lib.World;

namespace CivSim1Lib.Entities
{
    public abstract class Entity
    {
        public abstract void Tick(Zone zone);
    }
}