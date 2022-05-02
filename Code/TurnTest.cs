using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        public GameHandler turns;
        [Test]
        public void NewTestScriptSimplePasses()
        {
            AssertIsEqual(turns.IsPlayerTurn, true);
            AssertIsNotEqual(turns.isSkeletonTurn, false); // these should be true during player turn, if not, something is wrong
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
