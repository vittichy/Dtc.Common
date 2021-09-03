using Dtc.Common.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dtc.Common.Tests.Extensions
{
    /// <summary>
    /// String extensions tests
    /// </summary>
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void RemoveEndTextTo_Tests()
        {
            string test = null;
            var result = test.RemoveEndTextTo('x');
            Assert.IsNull(result);

            test = string.Empty;
            result = test.RemoveEndTextTo('x');
            Assert.AreEqual(test, result);

            test = "werdtwrt354t3ft5f";
            result = test.RemoveEndTextTo('|');
            Assert.AreEqual(test, result);

            test = "abc|";
            result = test.RemoveEndTextTo('|');
            Assert.AreEqual("abc", result);

            test = "|abc|";
            result = test.RemoveEndTextTo('|');
            Assert.AreEqual("|abc", result);

            test = "a|bc|";
            result = test.RemoveEndTextTo('|');
            Assert.AreEqual("a|bc", result);

            test = "a|bc||";
            result = test.RemoveEndTextTo('|');
            Assert.AreEqual("a|bc|", result);

            test = "|";
            result = test.RemoveEndTextTo('|');
            Assert.AreEqual("", result);

            test = "||";
            result = test.RemoveEndTextTo('|');
            Assert.AreEqual("|", result);
        }

    }
}
