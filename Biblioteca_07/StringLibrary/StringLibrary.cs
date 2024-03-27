namespace UtilityLibraries;

public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str) //toda string vai apresentar esse método
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch); //só retorna se o primeiro caractere for maiúsculo
    }
}
