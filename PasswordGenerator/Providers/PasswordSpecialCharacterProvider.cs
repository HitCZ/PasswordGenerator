using System.Collections.Generic;

namespace PasswordGenerator.Providers
{
    internal sealed class PasswordSpecialCharacterProvider : PasswordElementProvider<char>
    {
        public PasswordSpecialCharacterProvider()
        {
            FillCharacters(AvailableElements);
        }

        private void FillCharacters(HashSet<char> availableElements)
        {
            if (availableElements is null)
                return;

            availableElements.Add(' ');
            availableElements.Add('!');
            availableElements.Add('#');
            availableElements.Add('$');
            availableElements.Add('%');
            availableElements.Add('@');
            availableElements.Add('\'');
            availableElements.Add('(');
            availableElements.Add(')');
            availableElements.Add('*');
            availableElements.Add('+');
            availableElements.Add(',');
            availableElements.Add('-');
            availableElements.Add('.');
            availableElements.Add('/');
            availableElements.Add(':');
            availableElements.Add(';');
            availableElements.Add('<');
            availableElements.Add('=');
            availableElements.Add('>');
            availableElements.Add('?');
            availableElements.Add('@');
            availableElements.Add('[');
            availableElements.Add('\\');
            availableElements.Add(']');
            availableElements.Add('^');
            availableElements.Add('_');
            availableElements.Add('`');
            availableElements.Add('{');
            availableElements.Add('|');
            availableElements.Add('}');
            availableElements.Add('~');
        }
    }
}
