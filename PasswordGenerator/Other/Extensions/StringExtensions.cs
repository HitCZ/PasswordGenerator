﻿namespace PasswordGenerator.Other.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str) => str is null || str == string.Empty;
    }
}
