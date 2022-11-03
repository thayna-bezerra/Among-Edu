using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController sounds;

    [Space(10)]

    [Header("Efeitos Sonoros")]
    public AudioSource click;
    public AudioSource cutscene;
    public AudioSource acerto;
    public AudioSource erro;

    private void Awake()
    {
        sounds = this;
    }
}