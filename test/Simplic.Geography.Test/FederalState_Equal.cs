using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simplic.Geography.Test
{
    [TestClass]
    public class FederalState_Equal
    {
        [TestMethod]
        public void FederalTest_IsEqual()
        {
            var testId = Guid.NewGuid();

            var s1 = new FederalState();
            s1.Guid = testId;

            var s2 = new FederalState();
            s2.Guid = testId;

            Assert.AreEqual(s1, s2);
            Assert.IsTrue(s1 == s2);
        }

        [TestMethod]
        public void FederalTest_IsNotEqual()
        {
            var s1 = new FederalState();
            s1.Guid = Guid.NewGuid();

            var s2 = new FederalState();
            s2.Guid = Guid.NewGuid();

            Assert.AreNotEqual(s1, s2);
            Assert.IsFalse(s1 == s2);
        }

        [TestMethod]
        public void FederalTest_HashEqualIdHash()
        {
            var s1 = new FederalState();
            s1.Guid = Guid.NewGuid();

            Assert.AreEqual(s1.GetHashCode(), s1.Guid.GetHashCode());
        }

        [TestMethod]
        public void FederalTest_Linq()
        {
            var testId = Guid.NewGuid();

            var s1 = new FederalState();
            s1.Guid = testId;

            var s2 = new FederalState();
            s2.Guid = testId;

            var l1 = new[] { s1 };
            var l2 = new[] { s2 };

            Assert.AreEqual(l1.Except(l2).Count(), 0);
        }
    }
}
