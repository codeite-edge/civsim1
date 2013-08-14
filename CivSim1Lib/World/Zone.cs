using System;

namespace CivSim1Lib.World
{
    public class Zone
    {
        public Tile[,] Tiles { get; set; }

        public Zone()
        {
            Tiles = new Tile[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Tiles[i,j] = new Tile();
                }
            }
        }
    }
}