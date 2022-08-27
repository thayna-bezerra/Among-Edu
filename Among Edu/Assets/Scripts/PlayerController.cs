using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator AnimationPlayer, AnimationResposta1, AnimationResposta2, AnimationResposta3;

    public float speed;
    Rigidbody2D rgbd;

    public bool isActive;

    public bool encontrouResposta = false;
    public bool respostaErrada = false;

    public int vida = 3;
    public GameObject[] VidasHUD = new GameObject[3];

    public GameObject panelErrou;

    private void Start()
    {
        Time.timeScale = 1;
        AnimationPlayer = GetComponent<Animator>();
        rgbd = GetComponent<Rigidbody2D>();

        //panelAcertou.SetActive(false);
        panelErrou.SetActive(false);
    }

    private void FixedUpdate()
    {
        MovePlayer();
        AnimStatus();
    }

    private void Update()
    {
        HUDVida();
        if(vida <= 0)
        {
            panelErrou.SetActive(true);
            //Time.timeScale = 0;
        }
    }

    void MovePlayer()
    {
        Vector2 pos = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rgbd.velocity = pos * speed;

        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");

        if (a > 0)
        {
            isActive = true; //está ativo andando
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        else if (a < 0 || b < 0 || b > 0)
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
            AnimationPlayer.Play("PlayerCaminhando");
        }

        else
        {
            AnimationPlayer.Play("PlayerParado");
        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RespostaCorreta"))
        {
            //Time.timeScale = 0;
            //panelAcertou.SetActive(true);

            encontrouResposta = true;
        }

        if (collision.CompareTag("RespostaErrada/1"))
        {
            AnimationResposta1.Play("respostaErrada");
            respostaErrada = true;
            vida--;
        }

        if (collision.CompareTag("RespostaErrada/2"))
        {
            AnimationResposta2.Play("errada2");
            respostaErrada = true;
            vida--;
        }

        if (collision.CompareTag("RespostaErrada/3"))
        {
            respostaErrada = true;
            AnimationResposta3.Play("errada3");
            vida--;
        }

        if (collision.CompareTag("Enemy"))
        {
            print("tocou inimigo");
            vida--;
        }
    }

    void HUDVida()
    {

        switch (vida)
        {
            case 3:
                VidasHUD[0].SetActive(false); //com uma vida desativado
                VidasHUD[1].SetActive(false); //com duas vidas desativado
                VidasHUD[2].SetActive(true);  //com 3 vidas
                break;

            case 2:
                VidasHUD[0].SetActive(false);
                VidasHUD[1].SetActive(true);
                VidasHUD[2].SetActive(false);
                break;

            case 1:
                VidasHUD[0].SetActive(true);
                VidasHUD[1].SetActive(false);
                VidasHUD[2].SetActive(false);
                break;

            default:
                VidasHUD[0].SetActive(false);
                VidasHUD[1].SetActive(false);
                VidasHUD[2].SetActive(false);
                break;

        }
    }
}