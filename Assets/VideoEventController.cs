using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

public class VideoEventController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endText;

    void Start()
    {
        // Gắn event
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;

        // Chuẩn bị video
        videoPlayer.Prepare();
    }

    // Khi video load xong
    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video Prepared");
        vp.Play();
    }

    // Khi video kết thúc
    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Video Finished");

        if (endText != null)
            endText.SetActive(true);
    }

    void Update()
    {
        if (endText.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Continue...");
            // Có thể load scene ở đây
            // SceneManager.LoadScene("GameScene");
        }
    }
}
