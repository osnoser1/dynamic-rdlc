namespace DynamicRdlc.Rdl
{
    public static class Expression
    {
        public static string FieldsValue(string field) => "Fields!" + field + ".Value";

        public static string ReplaceSingleQuoteWithDoubleQuote(this string input) => input.Replace('\'', '\"');
    }
}