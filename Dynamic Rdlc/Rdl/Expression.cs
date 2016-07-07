namespace DynamicRdlc.Rdl
{
    public static class Expression
    {
        public static string FieldsValue(string field)
        {
            return "Fields!" + field + ".Value";
        }

        public static string ReplaceSingleQuoteWithDoubleQuote(this string input)
        {
            return input.Replace('\'', '\"');
        }
    }
}
