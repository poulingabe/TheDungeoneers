using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HealthTest
    {
        public Player player;
        [Test]
        public void HealthTestSimplePasses()
        {
            AssertIsEqual(player.maxHealth(type), integer); // will always return true, unless dead
        }

        [UnityTest]
        public IEnumerator HealthTestWithEnumeratorPasses()
        {
            yield return null;
        }
    }
}
