using UnityEngine;

public class GlobalAudioControl : MonoBehaviour
{
    bool isMute = false;
    bool isPause = false;

    void Update()
    {
        // M: Mute / Unmute
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMute = !isMute;

            if (isMute)
                AudioListener.volume = 0;
            else
                AudioListener.volume = 1;
        }

        // P: Pause / Resume
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPause = !isPause;

            AudioListener.pause = isPause;
        }
    }
}
