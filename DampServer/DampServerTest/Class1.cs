﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DampServerTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [ExpectedException]
        public void TestTestTest()
        {
            Console.WriteLine("Hej Hej  5");
            throw new Exception();
        }
    }
}