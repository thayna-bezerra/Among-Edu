using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controle : MonoBehaviour
{
    //Scripts para desativar
    public GameObject Player;
    public GameObject Spawn;
    public GameObject Enemy;
    public GameObject Enemy2;

    /*if(auxCheckValue)
       isPaused = false;
    else
    isPaused = true;

    if (isPaused)
        DesativarScripts();

    if (!isPaused)
        AtivarScripts();*/

    public void jogoPausado()
    {
        //Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<SpriteRenderer>().enabled = false;

        Enemy.GetComponent<EnemyControl>().enabled = false;
        Enemy2.GetComponent<EnemyControl>().enabled = false;
        Spawn.GetComponent<Spawn>().enabled = false;
    }

    public void jogoDespausado()
    {
        //Player.GetComponent<PlayerController>().enabled = true;
        Player.GetComponent<SpriteRenderer>().enabled = true;

        Spawn.GetComponent<Spawn>().enabled = true;
        Enemy.GetComponent<EnemyControl>().enabled = true;
        Enemy2.GetComponent<EnemyControl>().enabled = true;
    }

    public void iniciarGame()
    {
        SceneManager.LoadScene("Adicao");
    }

    public void RepetirRodada()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        jogoDespausado();
    }
}
