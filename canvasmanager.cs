using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    public Canvas lightCanvas;
    public Canvas darkCanvas;

    void Start()
    {
        string savedTheme = ThemeManager.LoadTheme();
        SetTheme(savedTheme);
    }

    public void SetTheme(string themeName)
    {
        if (themeName == "LightTheme")
        {
            lightCanvas.gameObject.SetActive(true);
            darkCanvas.gameObject.SetActive(false);
        }
        else if (themeName == "DarkTheme")
        {
            lightCanvas.gameObject.SetActive(false);
            darkCanvas.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("Invalid theme name: " + themeName);
        }
    }
}


