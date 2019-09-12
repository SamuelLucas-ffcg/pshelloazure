using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using pshelloazuree.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace pshelloazure.tests
{
    [TestFixture]
    class HomeTests
    {
        private Mock<IConfiguration> config;
        [SetUp]
        public void SetUp()
        {
            config = new Mock<IConfiguration>();
        }
        [Test]
        public void TestActionReturnsExeption()
        {
            var controller = new HomeController(config.Object);

            Assert.Throws<InvalidOperationException>(() => controller.Test());
        }
    }
}
