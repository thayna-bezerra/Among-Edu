using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform[] pontosPos = new Transform[4]; //Pontos com o valor de cada transform
    public GameObject[] numsTrocaPos = new GameObject[4]; //Numeros que serão transferidos entre esses pontos

    void Update()
    {
       
    }

    void irParaPosAleatoria()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //numsTrocaPos[4] = Random.Range(pontosPos[0], pontosPos[1], pontosPos[2], pontosPos[3]);

            //numsTrocaPos[0].transform.position = pontosPos[0];
        }
    }




}

    /*
    private List<Vector3> PosicoesJaSalvas = new List<Vector3>(); //é o array pontosPos
    public GameObject ObjetoParaInstanciar; //é o array numeros que trocam de posição
    public int MinX, MaxX, MinY, MaxY, MinZ, MaxZ; //não precisa pq já é a var de PosicoesJaSalvas
   
    private bool podeInstanciar, estaNoFor;
    
    void Start()
    {
        podeInstanciar = true;
        estaNoFor = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Vector3 posicaoAleatoria = new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));
            for (int x = 0; x < PosicoesJaSalvas.Count; x++)
            {
                if (PosicoesJaSalvas[x] == posicaoAleatoria)
                {
                    podeInstanciar = false;
                    estaNoFor = true;
                    Debug.Log("Posicao ja existente: " + posicaoAleatoria);
                }
            }
            if (podeInstanciar == false && estaNoFor == true)
            {
                Debug.Log("Tente novamente");
                podeInstanciar = true;
                estaNoFor = false;
            }
            if (podeInstanciar == true && estaNoFor == false)
            {
                Instantiate(ObjetoParaInstanciar, posicaoAleatoria, Quaternion.identity);
                PosicoesJaSalvas.Add(posicaoAleatoria);
            }


        }*/
