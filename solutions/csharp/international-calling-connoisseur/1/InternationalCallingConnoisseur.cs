public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new();

    public static Dictionary<int, string> GetExistingDictionary() => new() {
        [1] = "United States of America",
        [55] = "Brazil",
        [91] = "India"
    };

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName) 
        => new() { { countryCode, countryName } };

    public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> dict, int code, string name)
    {
        dict.TryAdd(code, name); return dict; 
    }

    public static string GetCountryNameFromDictionary(Dictionary<int, string> dict, int code) 
        => dict.TryGetValue(code, out var name) ? name : "";

    public static bool CheckCodeExists(Dictionary<int, string> dict, int code) 
        => dict.ContainsKey(code);

    public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> dict, int code, string name)
    {
        if (dict.ContainsKey(code)) dict[code] = name; return dict;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> dict, int code)
    {
        dict.Remove(code); return dict;
    }

    public static string FindLongestCountryName(Dictionary<int, string> dict) 
        => dict.Values.MaxBy(name => name.Length) ?? "";
}
