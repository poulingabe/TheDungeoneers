using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class StartTest
    {
        public Player player;
        [Test]
        public void StartTestSimplePasses()
        {
            AssertIsEqual(player.currentHealth, player.maxHealth); // player health at start should always be equal to max health
            AssertIsEqual(player.currentHealth, integer); // player health should always be an integer
            AssertIsNotEqual(Player.currentHealth, 0); // if player health at start is 0, game cannot start
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator StartTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
