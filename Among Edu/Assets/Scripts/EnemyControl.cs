using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Transform posInicial;
    public Transform posPlayer; //pegar a posição do player para segui-lo
    public float velocity;

    public bool isActive;
    public bool isStopped;

    public Animator AnimationEnemy;

    //public Rigidbody2D rgbd2D;
    [SerializeField]
    private SpriteRenderer spriteR;

    void Start()
    {
        isActive = false; 
        isStopped = true;
    }

    void Update()
    {
        if(isStopped == true && isActive == false)
        {
            StartCoroutine(forStoppedTrue());
        }

        if(isStopped == false && isActive == true)
        {
            StartCoroutine(forActiveTrue());
        }
    }

    IEnumerator forStoppedTrue()
    {
        inimigoParado();
        yield return new WaitForSeconds(10f);
        isStopped = false;
        isActive = true;
    }
    IEnumerator forActiveTrue()
    {
        inimigoAndando();
        //verificar lados do jogador
        

        yield return new WaitForSeconds(10f);
        isStopped = true;
        isActive = false;
    }

    void inimigoAndando()
    {
        AnimationEnemy.enabled = false;
        transform.position = Vector2.Lerp(transform.position, posPlayer.position, velocity * Time.deltaTime);
        

        //fazer o contrario para o enemy2, pois ele está com flip ativado ja
        if (posPlayer.transform.position.y > 0)
        {
            this.spriteR.flipX = false;
        }

        else if (posPlayer.transform.position.y < 0)
        {
            this.spriteR.flipX = true;
        }
    } 

    void inimigoParado()
    {
        AnimationEnemy.enabled = true;
        AnimationEnemy.Play("idle");
        transform.position = Vector3.Lerp(transform.position, posInicial.position, velocity * Time.deltaTime);
    }
}