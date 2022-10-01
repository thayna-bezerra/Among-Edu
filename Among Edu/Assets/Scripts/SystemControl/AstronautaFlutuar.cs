using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautaFlutuar : MonoBehaviour
{
	public float minForça;
	public float maxForça;

	public float maxDistancia;

	public float tempoRenovarForça;

	private float fatorDeForça;      //Variavel que vai receber a força
	private float tempoCorrenteRenovar;  //Tempo de influencia de força
	private float distanciaDoPivo;   //Variavel que mede a distancia do objeto para o pontoPivô

	private Vector2 direçao;  //Direçao na qual se aplica a força

	public GameObject pontoPivo;   //Objeto de referencia para a criação do diametro
	private Rigidbody2D corpoRigido;

	private bool novaDireçao;   //Variavel auxiliar para mudar a direçao

	public float z, y;
	public float timeRotation;

	// Use this for initialization
	void Start()
	{
		corpoRigido = GetComponent<Rigidbody2D>();
		novaDireçao = true;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		distanciaDoPivo = Vector3.Distance(transform.position, pontoPivo.transform.position);

		//Se meu objeto estiver fora do diametro especificado pelo Spring Joint no PontoPivô
		if (distanciaDoPivo >= maxDistancia)
		{
			//A direçao da força sera aplicada para o PontoPivô, assim voltando para dentro do diametro
			fatorDeForça = Random.Range(minForça, maxForça);
			tempoCorrenteRenovar = 0;
			direçao = (pontoPivo.transform.position - transform.position).normalized;  //.normalized e utilizado para pegar a direçao de um Vector3
			fatorDeForça = Random.Range(minForça, maxForça);
		}

		//Caso meu objeto estiver dentro do diametro especificado
		if (distanciaDoPivo < maxDistancia)
		{
			//Cronometro para alternar a direçao
			tempoCorrenteRenovar += Time.deltaTime;
			if (tempoCorrenteRenovar >= tempoRenovarForça)
			{
				tempoCorrenteRenovar = 0;
				novaDireçao = true;
			}

			//Direçao aleatoria
			if (novaDireçao)
			{
				direçao.x = Random.Range(-1f, 1f);
				direçao.y = Random.Range(-1f, 1f);
				fatorDeForça = Random.Range(minForça, maxForça);
				novaDireçao = false;
			}
		}
		//Objeto que receber a força
		corpoRigido.AddForce(direçao * fatorDeForça - corpoRigido.velocity);  //Eu tive que fazer o "-corpoRigido.velocity" para manter
	}                  //a velocidade do objeto


    private void Update()
    {
		GirarAstronautas();
    }

	void GirarAstronautas()
    {
		z = z + Time.deltaTime * timeRotation;
		transform.rotation = Quaternion.Euler(0, y, z); 
		
		if (z >= 360)
		{
			z = z - 360;
		}
	}
}
