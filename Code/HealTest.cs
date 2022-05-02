using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HealTest
    {
        public Item healthpot;
        // A Test behaves as an ordinary method
        [Test]
        public void HealTestSimplePasses()
        {
            AssertIsEqual(healthpot.Heal(), 20); // if health potion is not healing for 20, will fail
            AssertIsEqual(healthpot.Heal()(type), integer); // the type of all numbers in these tests should be integers
        }

        [UnityTest]
        public IEnumerator HealTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
