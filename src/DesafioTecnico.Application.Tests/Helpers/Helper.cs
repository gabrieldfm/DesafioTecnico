using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico.Application.Tests.Helpers
{
    public class Helper
    {
        public static object InvokePrivateMethod<T>(object classInstance, string method, object[] parameters) where T : class
        {
            var methodInfo = typeof(T).GetMethod(method, BindingFlags.NonPublic | BindingFlags.Instance);
            return methodInfo?.Invoke(classInstance, parameters);
        }
    }
}
