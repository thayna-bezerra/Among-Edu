using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator Animation;

    public float speed;
    Rigidbody2D rgbd;

    public bool isActive;

    private void Start()
    {
        Animation = GetComponent<Animator>();
        rgbd = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        AnimStatus();
    }

    void MovePlayer()
    {
        Vector2 pos = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rgbd.velocity = pos * speed;

        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");

        if (a > 0 || b > 0)
        {
            isActive = true; //está ativo andando
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        else if (a < 0 || b < 0)
        {
            isActive = true; //está ativo andando
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        else
        {
            isActive = false; //está parado
        }
    }

    void AnimStatus()
    {
        if (isActive)
        {
            Animation.Play("PlayerCaminhando");

        }

        else
        {
            Animation.Play("PlayerParado");
        }
    }
}
