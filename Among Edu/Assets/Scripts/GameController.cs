using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Variáveis da SOMA")]
    public int n1; //Números que deverão ser aleatórios e somado entre eles
    public int n2;
    public int resultadoSoma;

    [Header("Opções de Resultado ERRADO")]
    public int limiteNum = 3; //para sortear três numeros

    public int valorSorteado;
    public int[] respostasErradas = new int[3]; //qtd maxima de nums para verificar

    [Header("Textos")]
    public Text Tn1;
    public Text Tn2;
    public Text tResultado;

    public Text Tre1;
    public Text Tre2;
    public Text Tre3;

    void Update()
    {
        TextosCanvas();

        SortearNumeros();
        SomarNumeros(n1, n2);

        if (Input.GetKeyDown(KeyCode.S))
            GeradorDeRespostasErradas();
    }

    void SortearNumeros()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            n1 = Random.Range(0, 5);
            n2 = Random.Range(0, 5);

            //GeradorDeRespostasErradas();
        }
    }

    void SomarNumeros(int N1, int N2)
    {
        resultadoSoma = N1 + N2;
    }

    void GeradorDeRespostasErradas()
    {
        for(int i = 0; i <= limiteNum -1; i++)
        {
        Inicio:
            valorSorteado = Random.Range(0, 5);
            for(int x = 0; x <= limiteNum -1 ; x++)
            {
                if(valorSorteado == resultadoSoma)
                {
                    goto Inicio;
                }

                if(respostasErradas[x] == valorSorteado) //Verificar se o número sorteado é igual a algum elemento da array OU se é igual ao result da soma
                {
                    goto Inicio;
                }
            }

            respostasErradas[i] = valorSorteado;
        }
    }

    void TextosCanvas()
    {
        Tre1.text = respostasErradas[0].ToString();
        Tre2.text = respostasErradas[1].ToString();
        Tre3.text = respostasErradas[2].ToString();

        Tn1.text = n1.ToString();
        Tn2.text = n2.ToString();
        tResultado.text = resultadoSoma.ToString();
    }
}
