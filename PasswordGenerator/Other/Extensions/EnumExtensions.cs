using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PasswordGenerator.Other.Extensions
{
    public static class EnumExtensions<T> where T : Enum
    {
        public static List<ValueDescription> GetAllValueDescriptions()
        {
            var enumType = typeof(T);
            var values = Enum.GetValues(enumType).OfType<T>().ToList();
            var result = values.Select(v => new ValueDescription(v, GetEnumDescription(v))).ToList();

            return result;
        }

        public static string GetEnumDescription(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                      .Cast<DescriptionAttribute>()
                                      .ToList();

            return attributes.Any() ? attributes.First().Description : value.ToString();
        }
    }
}
