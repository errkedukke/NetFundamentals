using System;

namespace NetFundamentalsStandardLibrary
{
    public static class StringConcatinator
    {
        public static string Concatinate(string name)
        {
            return $"{DateTime.Now.ToString()} Hello {name}!";
        }
    }
}
