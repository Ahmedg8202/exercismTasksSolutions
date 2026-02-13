using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = identifier.Replace(' ', '_');
        identifier = identifier.Replace("\0", "CTRL");
        var sb = new StringBuilder();
        bool makeUpper = false;
        foreach (char c in identifier)
        {
            if (c == '-')
            {
                makeUpper = true;
            }
            else if (char.IsLetter(c) || c =='_')
            {
                if (c >= '\u03B1' && c <= '\u03C9')
                {
                    continue;
                }

                sb.Append(makeUpper ? char.ToUpper(c) : c);
                makeUpper = false;
            }
        }

        return sb.ToString();
    }
}
