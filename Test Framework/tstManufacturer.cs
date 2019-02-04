using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstManufacturer
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of our class clsManufacturer
            clsManufacturer AnManufacturer = new clsManufacturer();
            // check to see that the class is not null
            Assert.IsNotNull(AnManufacturer);
        }
    }
}
