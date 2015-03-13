using System;
using System.Reflection;

using V8.Net;

namespace TypeScriptLanguageService
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
        public T TypeMapper<T>(InternalHandle handle) {

			//if the handle has no result init an empty array or object
			if (handle == "undefined") {
				if (typeof(T).IsArray) {
					var array = Array.CreateInstance(typeof(T).GetElementType(), 0);
					T generic = Activator.CreateInstance<T>();
					array.SetValue(generic, 0);
					T obj = (T)(object)array;
					return obj;
				} else {
					T generic = Activator.CreateInstance<T>();
					return generic;
				}

            //@TODO do i need to care about enum parse?
            MethodInfo method = typeof(Utilities).GetMethod("TypeMapper");//@TODO dont call this every time

            //if T[] then we will return an T[]
            if (typeof(T).IsArray)
            {
                int arrayLength = handle.ArrayLength;
                //create array of from the generic type
                var array = Array.CreateInstance(typeof(T).GetElementType(), arrayLength);
                //we need this to call recursively the generic TypeMapper function


                for (int i = 0; i < arrayLength; i++)
                {   //Invoke recursive the Generic T TypeMapper ( InternalHandle) function 
                    MethodInfo genericMethod = method.MakeGenericMethod(array.GetType().GetElementType());
                    var result = genericMethod.Invoke(this,new object[] { handle.GetProperty(i) }); //@TODO change this to handle.GetProperty
                    array.SetValue(result, i);
                }
                T obj = (T)(object)array;
                return obj;
            }
            else //if T then we will return an T
            {
                var properties = typeof(T).GetProperties();
                T generic = Activator.CreateInstance<T>();

                foreach( var property in properties){

                    if (property.PropertyType.IsArray)
                    {
                        MethodInfo genericMethod = method.MakeGenericMethod(property.PropertyType);
                        var result = genericMethod.Invoke(this,new object[] { handle.GetProperty(property.Name)} ); //@TODO change this to handle.GetProperty
                        //This line takes the current property and then sets the value from the corrosponding handle object.
                        //<--set value----------------------------------------------><--get value from dynamic----@TODO change this to handle.Getproperty->
                        generic.GetType().GetProperty(property.Name).SetValue(generic,result);
                    }
                    else
                    {
                        //This line takes the current property and then sets the value from the corrosponding handle object.
                        //<--set value----------------------------------------------><--get value from dynamic----@TODO change this to handle.Getproperty->
                        string paramname = handle.GetProperty(property.Name);
                        if (property.PropertyType == typeof(string))
                        {
                            generic.GetType().GetProperty(property.Name).SetValue(generic, paramname);
                        }
                        else if (property.PropertyType == typeof(Boolean))
                        {
                            bool value;
                            Boolean.TryParse(paramname, out value);
                            generic.GetType().GetProperty(property.Name).SetValue(generic, value);
                        }
                        else if (property.PropertyType == typeof(int) || property.PropertyType == typeof(Enum) )
                        {
                            int value;
                            int.TryParse(paramname, out value);
                            generic.GetType().GetProperty(property.Name).SetValue(generic,value);
                        }
                    }
                }
                return (T)generic;
                // will throw on 0-length array, check for length == 0 and return default(T)
                // if do not want exception
            }
        }
    }
}

