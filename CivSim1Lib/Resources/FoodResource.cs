namespace CivSim1.Lib.Resources
{
    public class FoodResource : Resource
    {
        public FoodResource(int amount)
            : base(amount)
        {
        }
    }

    public class BerryResource : FoodResource
    {
        public BerryResource(int amount) : base(amount)
        {
        }
    }
}