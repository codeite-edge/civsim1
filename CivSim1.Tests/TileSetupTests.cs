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
            var foodResource = FoodResourceFactory.MakeHazelNut(1f);

            // Act
            tile.AddResource(foodResource);

            // Assert
            var foundResource = tile.GetResourceWithSignature(FoodResourceFactory.HazelNut);
            foundResource.Signature.Should().Be(FoodResourceFactory.HazelNut);
            foundResource.Mass.Should().BeApproximately(1f, 0.01f);
        }

        [Test]
        public void CanSetTileResourceWithTwoTypes()
        {
            // Arrange
            var tile = new Tile();
            var foodResource = FoodResourceFactory.MakeHazelNut(1f);
            var stoneResource = StoneResourceFactory.MakeGranite(1000f);

            // Act
            tile.AddResource(foodResource);
            tile.AddResource(stoneResource);

            // Assert
            tile.GetResourceWithSignature(FoodResourceFactory.HazelNut).Mass.Should().BeApproximately(1f, 0.01f);
            tile.GetResourceWithSignature(StoneResourceFactory.Granite).Mass.Should().BeApproximately(1000f, 0.01f);
        }

        [Test]
        public void CanAddToTileResources()
        {
            // Arrange
            var tile = new Tile();
            var foodResourceInitial = FoodResourceFactory.MakeHazelNut(10f);
            var foodResourceAdd = FoodResourceFactory.MakeHazelNut(20f);

            // Act
            tile.AddResource(foodResourceInitial);
            tile.AddResource(foodResourceAdd);

            // Assert
            tile.GetResourceWithSignature(FoodResourceFactory.HazelNut).Mass.Should().BeApproximately(30f, 0.01f);
        }
    }
}