using System.Collections.Generic;

namespace PasswordGenerator.Providers
{
    public class PasswordNumberProvider : PasswordElementProvider<int>
    {
        public PasswordNumberProvider()
        {
            FillNumbers(AvailableElements);
        }

        private void FillNumbers(HashSet<int> pNumbers)
        {
            if (pNumbers is null)
                return;

            for (var i = 0; i < 10; i++)
                pNumbers.Add(i);
        }
    }
}
