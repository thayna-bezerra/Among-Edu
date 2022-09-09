using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Variáveis da SOMA")]
    public int n1; //Números que deverão ser aleatórios e somado entre eles
    public int n2;
    public int resultadoSoma;

    //PRINCIPAIS NÚMEROS DA CONTA
    public SpriteRenderer imgN1, imgN2;
    public SpriteRenderer imgResposta;
    public SpriteRenderer imgN3, imgN4, imgN5; //opções de respostas incorretas

    public List<Sprite> numeros = new List<Sprite>(); //para guardar as sprites de numeros

    [Header("Opções de Resultado ERRADO")]
    public int limiteNum = 3; //para sortear três numeros

    public int valorSorteado;
    public int[] respostasErradas = new int[3]; //qtd maxima de nums para verificar

    private void Start()
    {
        SortearNumeros();
        SomarNumeros(n1, n2);

        GeradorDeRespostasErradas();

        imgN3.GetComponent<SpriteRenderer>().sprite = numeros[respostasErradas[0]];
        imgN4.GetComponent<SpriteRenderer>().sprite = numeros[respostasErradas[1]];
        imgN5.GetComponent<SpriteRenderer>().sprite = numeros[respostasErradas[2]];

    }

    void SortearNumeros()
    {
        n1 = Random.Range(0, 5);
        n2 = Random.Range(0, 5);

        imgN1.GetComponent<SpriteRenderer>().sprite = numeros[n1];
        imgN2.GetComponent<SpriteRenderer>().sprite = numeros[n2];
    }

    void SomarNumeros(int N1, int N2)
    {
        resultadoSoma = N1 + N2;
        imgResposta.GetComponent<SpriteRenderer>().sprite = numeros[resultadoSoma];
    }

    //Para as opções de respostas erradas
    void GeradorDeRespostasErradas()
    {
        for (int i = 0; i <= limiteNum - 1; i++)
        {
        Inicio:
            valorSorteado = Random.Range(0, 9);

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
        }
    }
}
