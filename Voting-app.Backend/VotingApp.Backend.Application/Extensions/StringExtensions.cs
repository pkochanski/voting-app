using System.Text;

namespace VotingApp.Backend.Application.Extensions;

public static class StringExtensions
{
    public static string ToLowerFirstLetter(this string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }
        var result = new StringBuilder();
        result.Append(value[..1].ToLower());
        result.Append(value[1..]);

        return result.ToString();
    }
}