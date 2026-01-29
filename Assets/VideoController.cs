using System;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    VideoPlayer videoPlayer;
    public GameObject endText;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.V))
       {
        
              videoPlayer.Play();
       }
       
    }




}
