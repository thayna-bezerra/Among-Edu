using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    Image image;
    public Animator AnimBalloon;

    bool isTouched = false;

    void Start()
    {
        AnimBalloon = GetComponent<Animator>();
        image = GetComponent<Image>();

        Color col = new Color(Random.Range(0.50f, 10.0f), Random.Range(0.0f, 1.0f), Random.Range(0.10f, 1.0f), 0.5f);
        image.color = col;
    }

    public void OnTouch()
    {
        if (isTouched) return;
        isTouched = true;
        SoundController.sounds.kabum.Play();
        AnimBalloon.Play("animBalloon");
        Destroy(this.gameObject, 0.2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("destruidor"))
        {
            Destroy(this.gameObject);
        }
    }
}
