using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void Quit()
    {
#if UNITY_EDITOR
            // Если приложение запущено из редактора, то выходим из редактора
            UnityEditor.EditorApplication.isPlaying = false;
#else
        // Иначе, если приложение запущено как standalone-приложение, то выходим из него
        Application.Quit();
#endif
    }
}
