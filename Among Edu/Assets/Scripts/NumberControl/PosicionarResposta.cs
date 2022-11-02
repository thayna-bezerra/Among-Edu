﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarResposta : MonoBehaviour
{
    public Transform destination;
    public float velocity = 3.0f;
    public PlayerController pc;

    //public GameObject panelAcertou;

    public Controle controle;
    public RoundsCounter rc;

    void Update()
    {
        if(pc.encontrouResposta == true)
        {
            SoundController.sounds.transition_acerto.Play();
            transform.position = Vector3.Lerp(transform.position, destination.position, velocity * Time.deltaTime); //Velocidade multiplicado por 0.02 segundos (deltaTime padrão)
            
            controle.GanhouJogoParado();
        }
    }
}
