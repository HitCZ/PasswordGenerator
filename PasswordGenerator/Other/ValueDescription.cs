using System;

namespace PasswordGenerator.Other
{
    public class ValueDescription
    {
        public object Value { get; }
        public string Description { get; }

        public ValueDescription(object value, string description)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
    }
}
