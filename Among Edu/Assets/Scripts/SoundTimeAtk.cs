using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTimeAtk : MonoBehaviour
{
    public AudioClip time_atk;
    AudioSource audioSource;

    public EnemyControl ec;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (ec.isStopped == true)
        {
            audioSource.Stop();
        }

        if (ec.isStopped == false)
        {
            audioSource.PlayOneShot(time_atk);
        }
    }
}
