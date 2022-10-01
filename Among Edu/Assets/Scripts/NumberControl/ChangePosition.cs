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