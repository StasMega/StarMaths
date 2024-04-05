using UnityEngine;

public class ThemeManager : MonoBehaviour
{

    public static void SaveTheme(string themeName)
    {
        PlayerPrefs.SetString("Theme", themeName);
    }

    public static string LoadTheme()
    {
        return PlayerPrefs.GetString("Theme", "DefaultTheme");
    }
}
