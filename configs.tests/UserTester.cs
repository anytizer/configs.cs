﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using configs.classes.readerwriter;
using configs.classes.structures;

namespace configs.tests
{
    [TestClass]
    public class UserTester
    {
        [TestMethod]
        public void UserTests()
        {
            string filename = "user-test.settings";

            string username_value = "uname";
            string password_value = "P002";

            structure_user values = new structure_user();

            values.username = username_value;
            values.password = password_value;

            rw_user rw = new rw_user(filename);
            rw.write(values);

            structure_user s = rw.read();

            Assert.AreEqual(username_value, s.username);
            Assert.AreEqual(password_value, s.password);
        }
    }
}
