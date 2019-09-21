using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator.Providers
{
    public sealed class PasswordEnglishCharactersProvider : PasswordElementProvider<char>
    {
        public PasswordEnglishCharactersProvider()
        {
            FillCharacters(AvailableElements);
        }

        public List<string> GetElements(int count, bool capitalCharacters)
        {
            var result = GetElements(count);

            return capitalCharacters ? result.Select(e => e.ToUpper()).ToList() : result;
        }

        private void FillCharacters(HashSet<char> pCharacters)
        {
            if (pCharacters is null)
                return;

            pCharacters.Add('a');
            pCharacters.Add('b');
            pCharacters.Add('c');
            pCharacters.Add('d');
            pCharacters.Add('e');
            pCharacters.Add('f');
            pCharacters.Add('g');
            pCharacters.Add('h');
            pCharacters.Add('i');
            pCharacters.Add('j');
            pCharacters.Add('k');
            pCharacters.Add('l');
            pCharacters.Add('m');
            pCharacters.Add('n');
            pCharacters.Add('o');
            pCharacters.Add('p');
            pCharacters.Add('q');
            pCharacters.Add('r');
            pCharacters.Add('s');
            pCharacters.Add('t');
            pCharacters.Add('u');
            pCharacters.Add('v');
            pCharacters.Add('w');
            pCharacters.Add('x');
            pCharacters.Add('y');
            pCharacters.Add('z');
        }
    }
}
