using UnityEngine;
using UnityEngine.InputSystem;


public class AudioController : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
      if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            audioSource.Play();
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            audioSource.Stop();
        }
    }
}
