using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public List<Vector2> areasPos = new List<Vector2>();//Pontos com o valor de cada transform
    public List<GameObject> numerosParaNovaPos = new List<GameObject>();//Numeros que serão transferidos entre esses pontos

    public int qtdNumeros = 4;

    //public Vector2 ultimoValor;
    public List<Vector2> ultimosValores = new List<Vector2>();

    int randomIndex; 
    Vector2 randomPos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            posicaoAleatoria();
    }

    void posicaoAleatoria()
    {
       /* for (int i = 0; i <= qtdNumeros - 1; i++)
        {
        Inicio:
            randomIndex = Random.Range(0, areasPos.Count);
            randomPos = areasPos[randomIndex];


            for (int x = 0; x <= qtdNumeros - 1; x++)
            {
                if (ultimosValores[x] == randomPos)
                {
                    goto Inicio;
                }

            }

            ultimosValores[i] = randomPos;
            

            
            //posSorteadas[i] = randomPos;

            int randomNums = Random.Range(0, numerosParaNovaPos.Count);
            GameObject randomNum = numerosParaNovaPos[randomNums];
            
            randomNum.transform.position = ultimosValores[i];
            //randomNum.transform.position = randomPos;
        }*/

    }

    /*void posicaoAleatoria()
    {
        for(int i = 0; i<= qtdNumeros -1; i++)
        {

            int randomIndex = Random.Range(0, areasPos.Count);
            Vector2 randomPos = areasPos[randomIndex];

            int randomNums = Random.Range(0, numerosParaNovaPos.Count);
            GameObject randomNum = numerosParaNovaPos[randomNums];

            randomNum.transform.position = randomPos;
        }

    }*/

    /*
    void irParaPosAleatoria()
    { ////PRECISO FAZER ISSO QUATRO VEZES // SEMPRE VERIFICAR SE JÁ NAO TEM

        for (int i = 0; i <= qtdNumeros - 1; i++)
        {
        Inicio:
            //GERANDO POSIÇÃO ALEATÓRIA
            int randomIndex = Random.Range(0, areasPos.Count);

            //SORTEANDO O NÚMERO QUE VAI PARA A POSICAO
            //int randomNums = Random.Range(0, numerosParaNovaPos.Count);

            //Se o ultimo numero gerado e a ultima posicao gerada
            for (int x = 0; x <= qtdNumeros; x++)
            {
                if (posSorteadas[x] == randomIndex)
                {
                    goto Inicio;
                } // || spriteSorteado[x] == randomNums
            }

            posSorteadas[i] = randomIndex;
            //spriteSorteado[i] = randomNums;



            //Vector2 randomPos = areasPos[randomIndex];
            //GameObject randomNum = numerosParaNovaPos[randomNums]; //game object

           // print(posSorteadas + "com os nums: " + spriteSorteado);

            //guardar numa lista os valores sorteados
            //randomNum.transform.position = randomPos;   //Definindo nova posicao para o numero
        }

            //print("GameObject " + randomNum + " vai para a posição " + randomPos);
            //randomNum.GetComponent<Transform>().position = randomPos;*/
        

        /*
        for (int i = 0; i <= limiteNum - 1; i++)
        {
        Inicio:
            valorSorteado = Random.Range(0, 5);

            for (int x = 0; x <= limiteNum - 1; x++)
            {
                if (valorSorteado == resultadoSoma)
                {
                    goto Inicio;
                }

                if (respostasErradas[x] == valorSorteado) //Verificar se o número sorteado é igual a algum elemento da array OU se é igual ao result da soma
                {
                    goto Inicio;
                }
            }

            respostasErradas[i] = valorSorteado;
        }*/
    
}