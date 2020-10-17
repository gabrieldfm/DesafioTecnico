using System;
using System.Reflection;

namespace Api2.Tests.Helpers
{
    public class Helper
    {
        public static object InvokePrivateMethod<T>(object classInstance, string method, object[] parameters) where T: class
        {
            var methodInfo = typeof(T).GetMethod(method, BindingFlags.NonPublic | BindingFlags.Instance);
            return methodInfo?.Invoke(classInstance, parameters);
        }
    }
}
