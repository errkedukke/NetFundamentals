using System;

namespace NetFundamentalsStandardLibrary
{
    public static class StringConcatinator
    {
        public static string Concatenate(string name)
            => $"{DateTime.Now} Hello {name}!";
    }
}
