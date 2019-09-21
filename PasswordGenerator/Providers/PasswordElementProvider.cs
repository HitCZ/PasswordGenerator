using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator.Providers
{
    public abstract class PasswordElementProvider<T> : IPasswordElementProvider
    {
        protected readonly HashSet<T> AvailableElements;
        private readonly Random random;

        protected PasswordElementProvider()
        {
            AvailableElements = new HashSet<T>();
            random = new Random();
        }

        public virtual List<string> GetElements(int count)
        {
            var randomCharacters = new List<string>();

            for (var i = 0; i < count; i++)
            {
                var randomIndex = random.Next(AvailableElements.Count);
                var randomChar = AvailableElements.ElementAt(randomIndex);
                randomCharacters.Add(randomChar.ToString());
            }

            return randomCharacters;
        }
    }
}
