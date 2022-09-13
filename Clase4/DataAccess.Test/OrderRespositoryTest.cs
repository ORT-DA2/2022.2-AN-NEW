using System.Linq;
using Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.Test;

[TestClass]
public class OrderRespositoryTest
{
    [TestMethod]
    public void TestGetAllOrdersOk()
    {
        List<Order> ordersToReturn = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                Name = "Papas fritas",
                Address = "Juan Gomez 3878",
                PutchaseNumber = 1,
                Price = 100,
                DeliveryDateTima = DateTime.Now.AddHours(1)
            },
            new Order()
            {
                Id = 2,
                Name = "Milanesa",
                Address = "Juan Gomez 3878",
                PutchaseNumber = 1,
                Price = 150,
                DeliveryDateTima = DateTime.Now.AddHours(1)
            }
        };       
        var options = new DbContextOptionsBuilder<ContextDb>()
										.UseInMemoryDatabase(databaseName: "TacosDB").Options;
        var context = new ContextDb(options);
	    ordersToReturn.ForEach(m => context.Add(m));
	    context.SaveChanges();
	    var repository = new OrderRepository(context);

	    var result = repository.GetAll();  

        Assert.IsTrue(ordersToReturn.SequenceEqual(result));
    }
}