using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controle : MonoBehaviour
{
    [Header("Objeto com os SCRIPTS para desativar")]
    public GameObject Player;
    public GameObject Spawn;
    public GameObject Enemy;
    public GameObject Enemy2;

    public GameObject panelPause;
    public GameObject btnPauseAtivado;
    public GameObject HUD;
    public bool isPaused;

    private void Start()
    {
        HUD.SetActive(true);
        btnPauseAtivado.SetActive(true);

        Player.GetComponent<SpriteRenderer>().enabled = true;
        //Player.GetComponent<PlayerController>().enabled = true;

        Spawn.GetComponent<Spawn>().enabled = true;
        Enemy.GetComponent<EnemyControl>().enabled = true;
        Enemy2.GetComponent<EnemyControl>().enabled = true;
    }

    private void Update()
    {
        if(isPaused == true)
            panelPause.SetActive(true);

        else
            panelPause.SetActive(false);
    }
    
    public void GanhouJogoParado()
    {
        btnPauseAtivado.SetActive(false);
        Player.GetComponent<SpriteRenderer>().enabled = false;
        Player.GetComponent<PlayerController>().enabled = false;

        Enemy.GetComponent<EnemyControl>().enabled = false;
        Enemy2.GetComponent<EnemyControl>().enabled = false;
        Spawn.GetComponent<Spawn>().enabled = false;
    }

    public void jogoPausado()
    {
        HUD.SetActive(false);
        isPaused = true;
        Player.GetComponent<SpriteRenderer>().enabled = false;
        Player.GetComponent<PlayerController>().enabled = false;

        Enemy.GetComponent<EnemyControl>().enabled = false;
        Enemy2.GetComponent<EnemyControl>().enabled = false;
        Spawn.GetComponent<Spawn>().enabled = false;
    }

    public void jogoDespausado()
    {
        HUD.SetActive(true);
        isPaused = false;
        Player.GetComponent<SpriteRenderer>().enabled = true;
        Player.GetComponent<PlayerController>().enabled = true;

        Spawn.GetComponent<Spawn>().enabled = true;
        Enemy.GetComponent<EnemyControl>().enabled = true;
        Enemy2.GetComponent<EnemyControl>().enabled = true;

    }

    public void RepetirRodada()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void voltarParaPrimeiraTela()
    {
        SceneManager.LoadScene("_Inicio");
    }

    public void sairDoGame()
    {
        Application.Quit();
    }
}
