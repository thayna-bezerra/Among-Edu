using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

namespace YoutubePlayer
{
    public class VideoControl : MonoBehaviour
    {
        public YoutubePlayer youtubePlayer;
        VideoPlayer videoPlayer;

        public Button btnReset;
        public Button btnVoltar;

        public Text Carregando;

        private void Start()
        {
            //AudioListener.volume = 0;
            Prepare();
        }

        private void Awake()
        {
            btnReset.interactable = true;
            btnVoltar.interactable = true;

            videoPlayer = youtubePlayer.GetComponent<VideoPlayer>();
            videoPlayer.prepareCompleted += VideoPlayerPreparedCompleted;
        }
        
        void VideoPlayerPreparedCompleted(VideoPlayer source)
        {
            btnReset.interactable = source.isPrepared;
            btnVoltar.interactable = source.isPrepared;
        }

        public async void Prepare()
        {
            print("Carregando vídeo...");
            Carregando.enabled = true;
            try
            {
                AudioListener.volume = 0;
                await youtubePlayer.PrepareVideoAsync();
                Carregando.enabled = false;

                PlayVideo();
            }
            catch
            {
                //chamar player
                AudioListener.volume = 0.5f;
                Carregando.text = ("ERRO");
            }
        }

        public void PlayVideo()
        {
            videoPlayer.Play();
        }

        /*public void PauseVideo()
        {
            videoPlayer.Pause();
        }*/

        public void ResetVideo()
        {
            videoPlayer.Stop();
            videoPlayer.Play();
        }

        public void VoltarInicio()
        {
            SceneManager.LoadScene("_Inicio"); 
        }

        void OnDestroy()
        {
            videoPlayer.prepareCompleted -= VideoPlayerPreparedCompleted;
        }
    }
}