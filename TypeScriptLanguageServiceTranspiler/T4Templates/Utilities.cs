using System;
using V8.Net;
using System.Reflection;

namespace CSharpTypeScriptLanguageServices
{
    public class Utilities
    {
        public Utilities()
        {
        }

        /// <summary>
        /// Maps generic v8 types to objects 
        /// 
        /// It reflects the object structure to v8 handels to retrieve the values
        /// then it constructs the object
        /// </summary>
        /// <returns>The mapped object T</returns>
        /// <param name="handle">InternalHandle v8 handle</param>
        /// <typeparam name="T">The 1st type parameter. Needs to have a default constructor</typeparam>
        public T TypeMapper<T>(dynamic handle) {
            T generic = Activator.CreateInstance<T>();
            return generic;
        }
    }
}

