using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace YoutubePlayer
{
    public class VideoControl : MonoBehaviour
    {
        public YoutubePlayer youtubePlayer;
        VideoPlayer videoPlayer;

        public Button btnPlay;
        public Button btnPause;
        public Button btnReset;

        private void Awake()
        {
            btnPlay.interactable = false;
            btnPause.interactable = false;
            btnReset.interactable = false;

            videoPlayer = youtubePlayer.GetComponent<VideoPlayer>();
            videoPlayer.prepareCompleted += VideoPlayerPreparedCompleted;
        }

        void VideoPlayerPreparedCompleted(VideoPlayer source)
        {
            btnPlay.interactable = source.isPrepared;
            btnPause.interactable = source.isPrepared;
            btnReset.interactable = source.isPrepared;
        }

        public async void Prepare()
        {
            print("Carregando vídeo...");
            try
            {
                await youtubePlayer.PrepareVideoAsync();
                print("video carregado");
            }
            catch
            {
                print("Error");
            }
        }

        public void PlayVideo()
        {
            videoPlayer.Play();
        }

        public void PauseVideo()
        {
            videoPlayer.Pause();
        }

        public void ResetVideo()
        {
            videoPlayer.Stop();
            videoPlayer.Play();
        }

        void OnDestroy()
        {
            videoPlayer.prepareCompleted -= VideoPlayerPreparedCompleted;
        }
    }
}