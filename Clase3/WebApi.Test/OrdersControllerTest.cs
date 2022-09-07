using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebAPI.Controllers;
using WebAPI.Models.Out;

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
        };//1

        OrderBasicInfoModel orderModel = new OrderBasicInfoModel()
        {
            Id = 1,
            DeliveryDateTime = DateTime.Now.AddHours(1)
        };//1

        var mock = new Mock<IOrderService>(MockBehavior.Strict);
        mock.Setup(o => o.Create(It.IsAny<Order>())).Returns(orderModel); //1
    	var controller = new OrderController(mock.Object);
	    var result = controller.Add(order); 
    	var createdResult = result as CreatedAtRouteResult; 
	    var model = createdResult.Value as OrderBasicInfoModel; 

        mock.VerifyAll();//2
        Assert.AreEqual(new OrderBasicInfoModel()
        {
            Id = order.Id,
            DeliveryDateTime = order.DeliveryDateTima
        },
            model);//3
    }
}