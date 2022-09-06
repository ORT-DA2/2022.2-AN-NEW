using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Moq;

namespace WebApi.Test;

[TestClass]
public class OrdersControllerTest
{
    [TestMethod]
    public void CreateValidOrderTest()
    {
        Order order = new Order()
        {
            Name = "Papas fritas",
            Address = "Juan Gomez 3878",
            PutchaseNumber = 1,
            Price = 100,
            DeliveryDateTima = DateTime.Now.AddHours(1)
        };

        var mock = new Mock<IStudentLogic>(MockBehavior.Strict); // 2

    }
}