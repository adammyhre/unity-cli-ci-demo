using NUnit.Framework;

namespace UnityCliCiDemo.Tests {
    public class SmokeTests {
        [Test]
        public void OnePlusOne_EqualsTwo() {
            Assert.AreEqual(2, 1 + 1);
        }
    }
}