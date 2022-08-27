using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    //public Transform[] pontosPos = new Transform[4]; //Pontos com o valor de cada transform
    //public GameObject[] numsTrocaPos = new GameObject[4]; //Numeros que serão transferidos entre esses pontos
       
    
    //Random rnd = new Random();

    public List<Vector2> posNums = new List<Vector2>();
    //public List<Transform> posNums = new List<Transform>();
    public List<GameObject> numsTrocaPos = new List<GameObject>();

    void Update()
    {
        irParaPosAleatoria();
    }


    void irParaPosAleatoria()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { ////PRECISO FAZER ISSO QUATRO VEZES // SEMPRE VERIFICAR SE JÁ NAO TEM
           
            //GERANDO POSIÇÃO ALEATORIA
            int randomIndex = Random.Range(0, posNums.Count); 
            //Transform randomPos  = posNums[randomIndex];
            Vector2 randomPos  = posNums[randomIndex];
            print("Posição atual " + randomPos);

            //GERANDO NUMERO ALEATORIO
            int randomNums = Random.Range(0, numsTrocaPos.Count); 
            GameObject randomNum  = numsTrocaPos[randomNums]; //game object
            print("GameObject gerado " + randomNum);


            print("GameObject " + randomNum + " vai para a posição " + randomPos);

            //randomNum.transform.position = randomPos;

            var novoVector = new Vector2(randomPos.x, randomPos.y);

            //randomNum.gameObject.transform.position = randomPos;
            //posição do trnasform de randomNum será igual a randomPos


            //Instantiate(numsTrocaPos[randomNum],posNums[randomPos]); 
            //está sendo criado dentro do objeto posição, e não usando o seu transform

        }
    }

   /* private void Instanciar()
    {
        int Rand = Random.Range(0, pontosPos.Length);
        int RandNums = Random.Range(0, numsTrocaPos.Length);
        Instantiate(numsTrocaPos[RandNums], pontosPos[Rand].transform.position, pontosPos[Rand].transform.rotation);
       
    }*/




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
