using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource musicSource;

    // ���������� ��� ������ ����
    void Start()
    {
        // �������� ��������� Audio Source
        musicSource = GetComponent<AudioSource>();

        // ��������� �������� ����
        musicSource.clip = musicClip;

        // ����������� ��������� ������������
        musicSource.loop = true;
        musicSource.volume = 0.5f;

        // ��������� ������������
        musicSource.Play();
    }
}
