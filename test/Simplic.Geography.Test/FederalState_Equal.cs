﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simplic.Geography.Test
{
    [TestClass]
    public class FederalState_Equal
    {
        /// <summary>
        /// Tests the comparison when both objects are null.
        /// </summary>
        [TestMethod]
        public void FederalTest_IsNull()
        {
            FederalState s1 = null;
            FederalState s2 = null;

            Assert.AreEqual(s1, s2);
            Assert.IsTrue(s1 == s2);
        }

        /// <summary>
        /// Tests the comparison when the first object is null.
        /// </summary>
        [TestMethod]
        public void FederalTest_IsNull2()
        {
            var s1 = new FederalState
            {
                Guid = Guid.NewGuid(),
            };
            FederalState s2 = null;

            Assert.AreNotEqual(s1, s2);
            Assert.IsFalse(s1 == s2);
        }

        /// <summary>
        /// Tests the comparison when the second object is null.
        /// </summary>
        [TestMethod]
        public void FederalTest_IsNull3()
        {
            FederalState s1 = null;
            var s2 = new FederalState
            {
                Guid = Guid.NewGuid()
            };

            Assert.AreNotEqual(s1, s2);
            Assert.IsFalse(s1 == s2);
        }


        [TestMethod]
        public void FederalTest_IsEqual()
        {
            var testId = Guid.NewGuid();

            var s1 = new FederalState
            {
                Guid = testId
            };

            var s2 = new FederalState
            {
                Guid = testId
            };

            Assert.AreEqual(s1, s2);
            Assert.IsTrue(s1 == s2);
        }

        [TestMethod]
        public void FederalTest_IsNotEqual()
        {
            var s1 = new FederalState
            {
                Guid = Guid.NewGuid()
            };

            var s2 = new FederalState
            {
                Guid = Guid.NewGuid()
            };

            Assert.AreNotEqual(s1, s2);
            Assert.IsFalse(s1 == s2);
        }

        [TestMethod]
        public void FederalTest_HashEqualIdHash()
        {
            var s1 = new FederalState
            {
                Guid = Guid.NewGuid()
            };

            Assert.AreEqual(s1.GetHashCode(), s1.Guid.GetHashCode());
        }

        [TestMethod]
        public void FederalTest_Linq()
        {
            var testId = Guid.NewGuid();

            var s1 = new FederalState
            {
                Guid = testId
            };

            var s2 = new FederalState
            {
                Guid = testId
            };

            var l1 = new[] { s1 };
            var l2 = new[] { s2 };

            Assert.AreEqual(l1.Except(l2).Count(), 0);
        }
    }
}
