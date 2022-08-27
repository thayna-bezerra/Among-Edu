using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberController : MonoBehaviour
{
    //Todos os Números - 0 a 9
    public List<GameObject> numeros = new List<GameObject>();

    //Para as posições de cada número - 4 posições para cada lista
    public List<Transform> primeiroAlgs = new List<Transform>();
    public List<Transform> segundoAlgs = new List<Transform>(); //substituir por matriz [2,4] //2 colunas, 4 linhas

    public GameController gc;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //PARA INSTANCIAR EM LUGARES ALEATÓRIOS
            //USAR LAÇO DE REPETIÇÃO PARA REPETIR 4 VEZES, UM PARA CARA POSIÇÃO (INSTANTIATE)
            int randomIndex = Random.Range(0, primeiroAlgs.Count);
            Transform randomPos = primeiroAlgs[randomIndex];


            Instantiate(numeros[gc.resultadoSoma], randomPos); //instanciando o valor da soma na primeira pos
            Instantiate(numeros[gc.respostasErradas[0]], randomPos); 
            Instantiate(numeros[gc.respostasErradas[1]], randomPos); 
            Instantiate(numeros[gc.respostasErradas[2]], randomPos);

            //Nova Rodada: deletar instancias
        }
    }



}