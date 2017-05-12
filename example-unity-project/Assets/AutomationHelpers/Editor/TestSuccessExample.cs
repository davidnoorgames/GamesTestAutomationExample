using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestSuccessExample {

	[Test]
	public void TestSuccessExampleSimplePasses() {
		// Use the Assert class to test conditions.
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator TestSuccessExampleWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        Assert.IsTrue(3 == 3);
        yield return null;
	}
}
