using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public List<Vector2> areasPos = new List<Vector2>();//Pontos com o valor de cada transform
    public List<GameObject> numerosParaNovaPos = new List<GameObject>();//Numeros que serão transferidos entre esses pontos

    public int limitePos = 5;

    //Lista para salvar todas as posições que ja foram sorteadas;
    public List<Vector2> posicoesSorteadas = new List<Vector2>();
    public List<GameObject> spritesSorteadas = new List<GameObject>();

    int randomIndex, randomNums;
    Vector2 randomPos;
    GameObject randomNum;

    private void Start()
    {
        chamarNovasPos();
    }

    void chamarNovasPos()
    {
        for (int i = 0; i < 4; i++)
        {
            gerarNovasPos();
            gerarNovasSpritesNums();
        }

        spritesSorteadas[0].transform.position = posicoesSorteadas[0];
        spritesSorteadas[1].transform.position = posicoesSorteadas[1];
        spritesSorteadas[2].transform.position = posicoesSorteadas[2];
        spritesSorteadas[3].transform.position = posicoesSorteadas[3];
    }

    void gerarNovasPos()
    {
        randomIndex = Random.Range(0, areasPos.Count);
        randomPos = areasPos[randomIndex];

        if (posicoesSorteadas.Contains(randomPos))
            gerarNovasPos();
        else
            posicoesSorteadas.Add(randomPos);
    }

    void gerarNovasSpritesNums()
    {
        randomNums = Random.Range(0, numerosParaNovaPos.Count);
        randomNum = numerosParaNovaPos[randomNums];

        if (spritesSorteadas.Contains(randomNum))
            gerarNovasSpritesNums();
        else
            spritesSorteadas.Add(randomNum);
    }
}
    /*void novaPos()
    {
        for (int i = 0; i <5; i++) //Está gerando e salvando as 4 posições na lista
        {
            
            randomIndex = Random.Range(0, areasPos.Count);
            randomPos = areasPos[randomIndex];

            if (posicoesSorteadas.Contains(randomPos))
            {
                randomIndex = Random.Range(0, areasPos.Count);
                randomPos = areasPos[randomIndex];
            }


            else
                posicoesSorteadas.Add(randomPos);
        }

        for (int i = 0; i <5; i++) //Está gerando e salvando as 4 posições na lista
        {
            int randomNums = Random.Range(0, numerosParaNovaPos.Count);
            GameObject randomNum = numerosParaNovaPos[randomNums];

            if (!spritesSorteadas.Contains(randomNum))
                 spritesSorteadas.Add(randomNum);
        }*/

        //for (int x = 0; x <4; x++)
        //spritesSorteadas[x].transform.position = posicoesSorteadas[x];

        //spritesSorteadas[0].transform.position = posicoesSorteadas[0];
        //spritesSorteadas[1].transform.position = posicoesSorteadas[1];
        //spritesSorteadas[2].transform.position = posicoesSorteadas[2];
        //spritesSorteadas[3].transform.position = posicoesSorteadas[3];

   


    /*void irParaNovaPos()
    {
            //Inicio:
        for(int i = 0; i <= limitePos-1; i++) //Está gerando e salvando as 4 posições na lista
        {
            int randomIndex = Random.Range(0, areasPos.Count);
            Vector2 randomPos = areasPos[randomIndex];

            if (!posicoesSorteadas.Contains(randomPos))
            {
                posicoesSorteadas.Add(randomPos);
                //goto Inicio;
            }
        }     
    
            //Inicio2:
        for(int i = 0; i <= limitePos-1; i++) //Está gerando e salvando as 4 posições na lista
        {
            int randomNums = Random.Range(0, numerosParaNovaPos.Count);
            GameObject randomNum = numerosParaNovaPos[randomNums];

            if (!spritesSorteadas.Contains(randomNum)) //se random num não estiver na lista, add randomnum a lista
            {
                spritesSorteadas.Add(randomNum);
                //goto Inicio2;
            }
        }


        for (int x = 0; x <= limitePos-1; x++)
        {
            spritesSorteadas[x].transform.position = posicoesSorteadas[x];
        }

    }

    void aaaa() //CODIGO PARA TROCAR POSIÇÃO DOS NÚMEROS UM POR UM
    {
            int randomIndex = Random.Range(0, areasPos.Count);
            Vector2 randomPos = areasPos[randomIndex];

            int randomNums = Random.Range(0, numerosParaNovaPos.Count);
            GameObject randomNum = numerosParaNovaPos[randomNums];

            randomNum.transform.position = randomPos;
        
    }*/


