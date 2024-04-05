using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource musicSource;

    // Вызывается при старте игры
    void Start()
    {
        // Получаем компонент Audio Source
        musicSource = GetComponent<AudioSource>();

        // Загружаем звуковой файл
        musicSource.clip = musicClip;

        // Настраиваем параметры проигрывания
        musicSource.loop = true;
        musicSource.volume = 0.5f;

        // Запускаем проигрывание
        musicSource.Play();
    }
}
