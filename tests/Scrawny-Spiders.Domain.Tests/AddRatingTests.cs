using Scrawny.Spider.Domain.Catalog;

namespace Scrawny_Spiders.Domain.Tests;

[TestClass]
public class AddRatingTests
{
    [TestMethod]
    public void Can_Create_Add_Rating()
    {
        // Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m);
        var rating = new Rating(5, "Name", "Review");

        //Act
        item.AddRating(rating);

        //Assert
        Assert.AreEqual(rating, item.Ratings[0]);
        
    }
}