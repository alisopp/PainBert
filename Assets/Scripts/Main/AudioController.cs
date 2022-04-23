using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip audioClip;

    public void PlaySound(AudioSource audioSource)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
