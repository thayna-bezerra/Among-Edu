using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public AudioSource themeMusic;

    private void Start()
    {
        themeMusic = GetComponent<AudioSource>();
        themeMusic.enabled = true;
    }

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

        if (objs.Length > 1) /////////// B U G ///////////////
        {
            Destroy(this.gameObject);
        }

            DontDestroyOnLoad(this.gameObject);
    }
}
