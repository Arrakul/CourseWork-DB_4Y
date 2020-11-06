using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class ShowComputerModelTests
    {
        [TestMethod()]
        public void StartTest()
        {
            var model = new ShowComputerModel();
            model.Start();
        }
    }
}