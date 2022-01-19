using System;
using System.ComponentModel;
namespace IkiCore
{
    public static class ExtensionType
    {
        /// <summary>
        /// Change the type of an object.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object ChangeType(this Type t, object value) => TypeDescriptor.GetConverter(t).ConvertFrom(value);
        /// <summary>
        /// Convert a type to another.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TC"></typeparam>
        public static void RegisterTypeConverter<T, TC>() where TC : TypeConverter => TypeDescriptor.AddAttributes(typeof(T), new TypeConverterAttribute(typeof(TC)));
    }
}
