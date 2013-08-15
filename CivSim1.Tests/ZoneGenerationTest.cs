using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CivSim1.Lib.Resources;
using CivSim1.Lib.World;
using NUnit.Framework;

namespace CivSim1.Tests
{
    public class ZoneGenerationTest
    {
        [Test]
        public void SeedingAZoneShouldCreateFoodResourcesOnSomeTiles()
        {
            // Arrange
            var zone = new Zone(10);
            var random = new Random(1);

            // Act
            zone.Seed(random);

            // Assert
        }
    }

    public class ZoneFindTests
    {
        [Test]
        public void CanFindResourcesInZone()
        {
            // Arrange
            var zone = new Zone(5);
            zone.Tiles[2, 3].AddResource(new FoodResource(100));

            // Act

            // Assert
        }
    }
}
