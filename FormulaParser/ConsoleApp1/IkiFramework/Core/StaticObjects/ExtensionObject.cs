using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using System.Linq;
namespace IkiCore
{
	public static class ExtensionObject
    {
        /// <summary>
        /// Change the object's type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ChangeType<T>(this object value) => (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(value);
        /// <summary>
        /// Check if the object have a specified function.
        /// </summary>
        /// <param name="objectToCheck"></param>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public static bool HasFunction(this object objectToCheck, string functionName) => objectToCheck.GetType().GetMethod(functionName) != null;
        /// <summary>
        /// Invoke the object's function from a given name and specified parameters.
        /// </summary>
        /// <param name="actualObject"></param>
        /// <param name="functionName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static object InvokeFunction(this object actualObject, string functionName, params object[] parameters)
        {
            if (actualObject.HasFunction(functionName))
            {
                return actualObject.GetType().GetMethod(functionName).Invoke(actualObject, parameters);
            }
            return null;
        }
        /// <summary>
        /// Return the name of the object's variables.
        /// </summary>
        /// <param name="actualObject"></param>
        /// <param name="bindingFlags"></param>
        /// <returns></returns>
        public static string[] GetObjectVariablesNames(this object actualObject, BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance)
        {
            FieldInfo[] fi = actualObject.GetType().GetFields(bindingFlags);
            string[] names = new string[fi.Length];
            for (int i = 0; i < fi.Length; i++)
            {
                names[i] = fi[i].Name;
            }
            return names;
        }
        /// <summary>
        /// Return the value of the variables from a given name.
        /// </summary>
        /// <param name="actualObject"></param>
        /// <param name="VariableName"></param>
        /// <returns></returns>
        public static object GetVariableValue(this object actualObject, string VariableName) => actualObject.GetType().GetField(VariableName).GetValue(actualObject);
        /// <summary>
        /// Return all function's name of the object.
        /// </summary>
        /// <param name="actualObject"></param>
        /// <returns></returns>
        public static string[] GetAllFunctionsNames(this object actualObject)
        {
            MethodInfo[] methods = actualObject.GetType().GetMethods();
            string[] names = new string[methods.Length];
            for (int i = 0; i < methods.Length; i++)
            {
                names[i] = methods[i].Name;
            }
            return names;
        }
        /// <summary>
        /// Return the count of all function that have a name that begin the same as the functionStartingName.
        /// </summary>
        /// <param name="actualObject"></param>
        /// <param name="functionStartingName"></param>
        /// <returns></returns>
        public static int CountFunctions(this object actualObject, string functionStartingName = "")
        {
            if (functionStartingName == "")
            {
                return actualObject.GetAllFunctionsNames().Length;
            }
            int count = 0;
            string[] funcName = actualObject.GetAllFunctionsNames();
            for (int i = 0; i < funcName.Length; i++)
            {
                if (funcName[i].StartsWith(functionStartingName))
                {
                    count++;
                }
            }
            return count;
        }
        public static FieldInfo GetField(this object target, string fieldName) => GetAllFields(target, f => f.Name.Equals(fieldName, StringComparison.InvariantCulture)).FirstOrDefault();
        public static IEnumerable<FieldInfo> GetAllFields(this object target, Func<FieldInfo, bool> predicate)
        {
            List<Type> types = new List<Type>()
            {
                target.GetType()
            };
            while (types.Last().BaseType != null)
            {
                types.Add(types.Last().BaseType);
            }
            for (int i = types.Count - 1; i >= 0; i--)
            {
                IEnumerable<FieldInfo> fieldInfos = types[i].GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly).Where(predicate);
                foreach (FieldInfo fieldInfo in fieldInfos)
                {
                    yield return fieldInfo;
                }
            }
        }
        public static IEnumerable<PropertyInfo> GetAllProperties(this object target, Func<PropertyInfo, bool> predicate)
        {
            List<Type> types = new List<Type>()
            {
                target.GetType()
            };
            while (types.Last().BaseType != null)
            {
                types.Add(types.Last().BaseType);
            }
            for (int i = types.Count - 1; i >= 0; i--)
            {
                IEnumerable<PropertyInfo> propertyInfos = types[i].GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly).Where(predicate);
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    yield return propertyInfo;
                }
            }
        }
        public static IEnumerable<MethodInfo> GetAllMethods(this object target, Func<MethodInfo, bool> predicate)
        {
            IEnumerable<MethodInfo> methodInfos = target.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(predicate);

            return methodInfos;
        }
        public static PropertyInfo GetProperty(this object target, string propertyName) => GetAllProperties(target, p => p.Name.Equals(propertyName, StringComparison.InvariantCulture)).FirstOrDefault();
        public static MethodInfo GetMethod(this object target, string methodName) => GetAllMethods(target, m => m.Name.Equals(methodName, StringComparison.InvariantCulture)).FirstOrDefault();
    }
}
