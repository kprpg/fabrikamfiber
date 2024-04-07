using FabrikamFiber.DAL.Data;
using FabrikamFiber.DAL.Models;
using FabrikamFiber.Web.Controllers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikamFiber.WebTests.Controllers
{
    [TestFixture]
    internal class ServiceTicketsControllerTests
    {
        private Mock<IScheduleItemRepository> mockScheduleItemRepository;
        private Mock<ICustomerRepository> mockCustomerRepository;
        private Mock<IEmployeeRepository> mockEmployeeRepository;
        private Mock<IServiceTicketRepository> mockServiceTicketRepository;
        private Mock<IServiceLogEntryRepository> mockServiceLogEntryRepository;

        private ServiceTicketsController serviceTicketsController;

        //[SetUp]
        //public void SetUp()
        //{
        //    mockScheduleItemRepository = new Mock<IScheduleItemRepository>();
        //    serviceTicketsController = new ServiceTicketsController(mockCustomerRepository, mockEmployeeRepository,mockServiceTicketRepository, mockServiceTicketRepository, mockScheduleItemRepository);
        //}

        //[Test]
        //public void InsertOrUpdate_NewEntity_ShouldAddToRepository()
        //{
        //    // Arrange
        //    var scheduleItem = new ScheduleItem { ID = 0 };

        //    // Act
        //    object value = serviceTicketsController.InsertOrUpdate(scheduleItem);

        //    // Assert
        //    mockScheduleItemRepository.Verify(r => r.InsertOrUpdate(scheduleItem), Times.Once);
        //}

        //[Test]
        //public void InsertOrUpdate_ExistingEntity_ShouldUpdateInRepository()
        //{
        //    // Arrange
        //    var scheduleItem = new ScheduleItem { ID = 1 };

        //    // Act
        //    serviceTicketsController.InsertOrUpdate(scheduleItem);

        //    // Assert
        //    mockScheduleItemRepository.Verify(r => r.InsertOrUpdate(scheduleItem), Times.Never);
        //    mockScheduleItemRepository.Verify(r => r.Find(scheduleItem.ID), Times.Once);
        //    mockScheduleItemRepository.Verify(r => r.Save(), Times.Once);
        //}

        //[Test]
        //public void Delete_ShouldRemoveFromRepository()
        //{
        //    // Arrange
        //    var scheduleItemId = 1;

        //    // Act
        //    serviceTicketsController.Delete(scheduleItemId);

        //    // Assert
        //    mockScheduleItemRepository.Verify(r => r.Delete(scheduleItemId), Times.Once);
        //    mockScheduleItemRepository.Verify(r => r.Save(), Times.Once);
        //}
    }
}
