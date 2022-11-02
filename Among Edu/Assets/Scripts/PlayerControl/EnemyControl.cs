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

    public Transform posEnemy;

    public SpriteRenderer sr;

    [SerializeField]
    public PlayerController pc; 

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

        yield return new WaitForSeconds(8f);

        isStopped = false;
        isActive = true;
    }

    IEnumerator forActiveTrue()
    {
        inimigoAndando();

        yield return new WaitForSeconds(8f);

        isStopped = true;
        isActive = false;
    }

    void inimigoAndando()
    {
        AnimationEnemy.enabled = false;
        transform.position = Vector2.Lerp(transform.position, posPlayer.position, velocity * Time.deltaTime);

        if (this.gameObject.tag == "Enemy")
        {
            if (transform.position.x > posPlayer.position.x)
                sr.flipX = true;
            else sr.flipX = false;
        }

        if(this.gameObject.tag == "Enemy2")
        {
            if (transform.position.x > posPlayer.position.x)
                sr.flipX = false;
            else sr.flipX = true;
        }
    } 

    void inimigoParado()
    {
        transform.position = Vector2.Lerp(transform.position, posInicial.position, velocity * Time.deltaTime);
        AnimationEnemy.enabled = true;
        AnimationEnemy.Play("idle");

        //estar do lado correto quando voltar para a pos inicial
        if (this.gameObject.tag == "Enemy" || this.gameObject.tag == "Enemy2")
            sr.flipX = false;
    }
}