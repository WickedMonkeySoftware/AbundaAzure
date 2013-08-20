using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace api.Tests
{
    /// <summary>
    /// Summary description for Various
    /// </summary>
    [TestClass]
    public class Various
    {
        [TestMethod]
        public void RSAParameters()
        {
            var token = "abundatrade";
            var encrypted = RSAClass.Encrypt(token);
            var decrypted = RSAClass.Decrypt(encrypted);

            Assert.AreEqual(token, decrypted);
        }
    }
}
