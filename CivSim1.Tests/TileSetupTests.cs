using CivSim1.Lib.Resources;
using CivSim1.Lib.World;
using FluentAssertions;
using NUnit.Framework;

namespace CivSim1.Tests
{
    public class TileSetupTests
    {
        [Test]
        public void CanSetEmptyTileResource()
        {
            // Arrange
            var tile = new Tile();
            var foodResource = new FoodResource(100);

            // Act
            tile.AddResource(foodResource);

            // Assert
            var result = tile.GetResourceAgrigate(new FoodResource(0));
            result.Amount.Should().Be(100);
        }

        [Test]
        public void CanSetTileResourceWithTwoTypes()
        {
            // Arrange
            var tile = new Tile();
            var foodResource = new FoodResource(55);
            var stoneResource = new StoneResource(66);

            // Act
            tile.AddResource(foodResource);
            tile.AddResource(stoneResource);

            // Assert
            tile.GetResourceAgrigate(new FoodResource(0)).Amount.Should().Be(55);
            tile.GetResourceAgrigate(new StoneResource(0)).Amount.Should().Be(66);
        }

        [Test]
        public void CanAddToTileResources()
        {
            // Arrange
            var tile = new Tile();
            var foodResourceInitial = new FoodResource(25);
            var foodResourceAdd = new FoodResource(50);

            // Act
            tile.AddResource(foodResourceInitial);
            tile.AddResource(foodResourceAdd);

            // Assert
            tile.GetResourceAgrigate(new FoodResource(0)).Amount.Should().Be(75);
        }

        [Test]
        public void CanGetAgrigateResources()
        {
            // Arrange
            var tile = new Tile();
            var foodResourceInitial = new BerryResource(25);
            var foodResourceAdd = new NutsResource(50);

            // Act
            tile.AddResource(foodResourceInitial);
            tile.AddResource(foodResourceAdd);

            // Assert
            tile.GetResourceAgrigate(new FoodResource(0)).Amount.Should().Be(75);
        }
    }
}