using System;

namespace CivSim1.Lib.World
{
    public class Zone
    {
        private readonly int _size;
        public Tile[,] Tiles { get; set; }

        public Zone(int size)
        {
            _size = size;
            Tiles = new Tile[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var tile = new Tile();
                    Tiles[i, j] = tile;
                }
            }
        }

        public void Seed(Random random)
        {
            
        }
    }
}