using Microsoft.VisualStudio.TestTools.UnitTesting;
using T8_VoetbalToernooi.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_VoetbalToernooi.Controller.Tests
{
    [TestClass()]
    public class DocentControllerTests
    {
/* header
 * Niek van der Heijden
 * 18-6-25
 */
        [TestMethod()]
        public void CreateTest()
        {
            DocentController controller = new DocentController();
            var docent = new Model.DocentModel
            {
                Naam = "Test Docent",
                Email = "testdocent@example.com",
                Rol = "Admin"
            };

            // Act
            int result = controller.Create(docent);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}