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
    public int respostaErrada1; //VERIFICAR RESULTADO FINAL PARA NÃO SORTEAR O MESMO NÚMERO
    public int respostaErrada2; //NÃO PODE REPETIR ENTRE ELAS
    public int respostaErrada3;

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

        GeradorDeRespostasErradas();

        SortearNumeros();
        SomarNumeros(n1, n2);
    }

    void SortearNumeros()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            n1 = Random.Range(0, 9);
            n2 = Random.Range(0, 9);
        }
    }

    void SomarNumeros(int N1, int N2)
    {
        resultadoSoma = N1 + N2;
    }

    void GeradorDeRespostasErradas()
    {
        /*int valorMin = 0, valorMax = 30;
        int valorSorteado;

        for(int i = 0; i < 3; i--)
        {
            valorSorteado = Random.Range(valorMin, valorMax);
        }*/
        if (Input.GetKeyDown(KeyCode.S))
        {
            respostaErrada1 = Random.Range(0, 30);
            respostaErrada2 = Random.Range(0, 30);
            respostaErrada3 = Random.Range(0, 30);
        }
    }

    void TextosCanvas()
    {
        Tre1.text = respostaErrada1.ToString();   
        Tre2.text = respostaErrada2.ToString();   
        Tre3.text = respostaErrada3.ToString();   

        Tn1.text = n1.ToString();
        Tn2.text = n2.ToString();
        tResultado.text = resultadoSoma.ToString();
    }
}
