using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public float targetVolume = 0.5f; // 设定的目标音量

 
    void Update()
    {
        SetAudioSourcesVolume(targetVolume);
    }

    void SetAudioSourcesVolume(float volume)
    {
        // 获取当前场景中所有的 AudioSource，包括未激活的对象
        AudioSource[] audioSources = GameObject.FindObjectsOfType<AudioSource>(true);

        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = DataSounds.sound; // 设定音量
        }
    }
}
