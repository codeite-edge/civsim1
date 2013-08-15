namespace CivSim1.Lib.Resources
{
    public class Resource
    {
        protected Resource(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }
    }
}
