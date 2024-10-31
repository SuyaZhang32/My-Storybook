using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public float targetVolume = 0.5f; // �趨��Ŀ������

 
    void Update()
    {
        SetAudioSourcesVolume(targetVolume);
    }

    void SetAudioSourcesVolume(float volume)
    {
        // ��ȡ��ǰ���������е� AudioSource������δ����Ķ���
        AudioSource[] audioSources = GameObject.FindObjectsOfType<AudioSource>(true);

        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = DataSounds.sound; // �趨����
        }
    }
}
