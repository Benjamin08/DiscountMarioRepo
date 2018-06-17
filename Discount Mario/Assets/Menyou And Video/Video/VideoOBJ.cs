using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class VideoOBJ : MonoBehaviour {

    public VideoClip[] videoClips;
    private VideoPlayer videoPlayer;


    // Use this for initialization
    void Start () {

        videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.targetTexture.Release();
        int randomClip = Random.Range(0, 4);
        videoPlayer.clip = videoClips[randomClip];

    }

    // Update is called once per frame
    void Update () {

        if (videoPlayer.isPlaying == false)
        {
            //Destroy(this.gameObject);
        }

        }
}
