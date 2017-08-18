using System;
using System.ComponentModel;

namespace Cake.Services
{
    public static class EnumExtension
    {
        /// <summary>
        ///     扩展方法，获得枚举的Description
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <param name="nameInstend">当枚举没有定义DescriptionAttribute,是否用枚举名代替，默认使用</param>
        /// <returns>枚举的Description</returns>
        public static string GetDescription(this Enum value, bool nameInstend = true)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            if (name == null)
                return null;
            var field = type.GetField(name);
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attribute == null && nameInstend)
                return name;
            return attribute?.Description;
        }
    }
}