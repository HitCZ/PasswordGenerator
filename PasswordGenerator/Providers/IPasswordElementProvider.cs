using System.Collections.Generic;

namespace PasswordGenerator.Providers
{
    public interface IPasswordElementProvider
    {
        List<string> GetElements(int count);
    }
}
