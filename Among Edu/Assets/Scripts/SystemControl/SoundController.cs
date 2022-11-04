using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController sounds;

    [Space(10)]

    [Header("Efeitos Sonoros")]
    public AudioSource click;
    public AudioSource acerto;
    public AudioSource erro;

    [Header("Configuração dos Sons")]
    public bool audioOn;
    public Button btnAudio;
    public Sprite btnEmptyOff;
    public Sprite btnOn;

    private void Awake()
    {
        sounds = this;
    }
    private void Start()
    {
        audioOn = true;
    }

    public void MusicGame() //esse metodo sera chamado no botão "btnAudio"
    {
        audioOn = !audioOn; //verificar qual estado atual da bool audioOn
        SetBool("StateAudio", audioOn);

        if (audioOn == true)
        {
            AudioListener.volume = 0.5f;
            btnAudio.image.sprite = btnOn;
        }

        else if (audioOn == false)
        {
            AudioListener.volume = 0;
            btnAudio.image.sprite = btnEmptyOff;
        }
    }

    public bool GetBool(string stateAudio)
    {
        int a = PlayerPrefs.GetInt(stateAudio);

        if (a == 1)
        {
            btnAudio.image.sprite = btnOn;
            return true;
        }
        else
        {
            btnAudio.image.sprite = btnEmptyOff;
            return false;

        }
    }

    public void SetBool(string stateAudio, bool b)
    {
        if (b == true)
            PlayerPrefs.SetInt(stateAudio, 1);

        if (b == false)
            PlayerPrefs.SetInt(stateAudio, 0);
    }

}