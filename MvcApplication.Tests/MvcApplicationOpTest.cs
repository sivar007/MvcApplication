using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MvcApplication.Controllers;

namespace MvcApplication.tests
{
    [TestClass]
    public class MvcApllicationOpTest
    {
        [TestMethod]

        public void name()
        {
            AuthenticateController DC = new AuthenticateController();
            //Act
            string result = DC.logon2("sivaravula", "Bahubali");

            //Assert
            Assert.AreEqual("Success", result);

        }

    }
}
