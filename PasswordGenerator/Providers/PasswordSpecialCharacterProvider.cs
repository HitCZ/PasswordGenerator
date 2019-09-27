using System.Collections.Generic;

namespace PasswordGenerator.Providers
{
    public sealed class PasswordSpecialCharacterProvider : PasswordElementProvider<char>
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
