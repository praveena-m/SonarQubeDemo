﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetStatusTest()
        {
            Assert.IsNull(Program.GetStatus());
        }
    }
}