using System;
using NUnit.Framework;

namespace CoreFramework.Logger
{
    public static class Log
    {        
        public static void Info(string message)
        {
            DateTime timestamp = DateTime.Now;

            Console.WriteLine(timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff -> ") + message);
        }

        public static void InfoFocus(string message)
        {
            DateTime timestamp = DateTime.Now;

            Console.WriteLine("");
            Info(message);
            Console.WriteLine(string.Empty);
        }

        public static void AssertFail(string failureMessage)
        {
            Assert.Fail(failureMessage);
        }

        public static void AssertIsTrue(bool condition, string message)
        {
            Assert.IsTrue(condition, message);

            Log.Info($"AssertIsTrue Passed! '{message}'");
        }

        public static void AssertIsFalse(bool condition, string message)
        {
            Assert.IsFalse(condition, message);

            Log.Info($"AssertIsFalse Passed! '{message}'");
        }

        public static void AssertIsNull(object something, string message)
        {
            Assert.IsNull(something, message);

            Log.Info($"AssertIsNull Passed! '{message}'");
        }

        public static void AssertIsNotNull(object something, string message)
        {
            Assert.IsNotNull(something, message);

            Log.Info($"AssertIsNotNull Passed! '{message}'");
        }

        public static void AssertAreEquals(string expected, string actual, string message)
        {
            Assert.AreEqual(expected, actual, message);

            Log.Info($"AssertAreEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreNotEquals(string expected, string actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);

            Log.Info($"AssertAreNotEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreEquals(int expected, int actual, string message)
        {
            Assert.AreEqual(expected, actual, message);

            Log.Info($"AssertAreEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreNotEquals(int expected, int actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);

            Log.Info($"AssertAreNotEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }


        public static void AssertAreEquals(double expected, double actual, string message)
        { 
            Assert.AreEqual(expected, actual, message);
            Log.Info($"AssertAreEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreNotEquals(double expected, double actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
            Log.Info($"AssertAreNotEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreEquals(decimal expected, decimal actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
            Log.Info($"AssertAreEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreNotEquals(decimal expected, decimal actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
            Log.Info($"AssertAreNotEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreEquals(object expected, object actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
            Log.Info($"AssertAreEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }

        public static void AssertAreNotEquals(object expected, object actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
            Log.Info($"AssertAreNotEquals Passed! '{expected}' vs '{actual}' - '{message}'");
        }
        
    }
}
