using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controle : MonoBehaviour
{
    [Header("Objeto com os SCRIPTS para desativar")]
    public GameObject Player;
    public GameObject Spawn;
    public GameObject Enemy;
    public GameObject Enemy2;

    public GameObject panelPause;
    public GameObject panelSair;

    public GameObject btnPauseAtivado;
    public GameObject btnSair;

    public GameObject HUD;

    public bool isPaused;

    public Text textName;
    public string username;

    private void Start()
    {
        username = PlayerPrefs.GetString("User"); //pegando dado salvo no "user" e aplicando noutra variavel

        if (username == "")
        {
            username = "Você";
            textName.text = username.ToString();
        }

        else
            textName.text = username.ToString();

        HUD.SetActive(true);
        btnPauseAtivado.SetActive(true);
        btnSair.SetActive(true);

        Player.GetComponent<SpriteRenderer>().enabled = true;
        Player.GetComponent<BoxCollider2D>().enabled = true; ///

        textName.enabled = true;

        Spawn.GetComponent<Spawn>().enabled = true;
        Enemy.GetComponent<EnemyControl>().enabled = true;
        Enemy2.GetComponent<EnemyControl>().enabled = true;
    }

    private void Update()
    {
        if (isPaused == true)
            panelPause.SetActive(true);

        else
            panelPause.SetActive(false);
    }
    
    public void GanhouJogoParado()
    {
        SoundController.sounds.click.Play();

        btnPauseAtivado.SetActive(false);
        btnSair.SetActive(false);

        Player.GetComponent<SpriteRenderer>().enabled = false;
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<BoxCollider2D>().enabled = false; ///

        textName.enabled = false;

        Enemy.GetComponent<EnemyControl>().enabled = false;
        Enemy2.GetComponent<EnemyControl>().enabled = false;
        Spawn.GetComponent<Spawn>().enabled = false;
    }

    public void jogoPausado()
    {
        SoundController.sounds.click.Play();

        HUD.SetActive(false);

        isPaused = true;

        Player.GetComponent<SpriteRenderer>().enabled = false;
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<BoxCollider2D>().enabled = false; ///

        textName.enabled = false;

        Enemy.GetComponent<EnemyControl>().enabled = false;
        Enemy2.GetComponent<EnemyControl>().enabled = false;
        Spawn.GetComponent<Spawn>().enabled = false;
    }

    public void jogoDespausado()
    {
        SoundController.sounds.click.Play();

        HUD.SetActive(true);

        isPaused = false;

        Player.GetComponent<SpriteRenderer>().enabled = true;
        Player.GetComponent<PlayerController>().enabled = true;
        Player.GetComponent<BoxCollider2D>().enabled = true; ///

        textName.enabled = true;

        Spawn.GetComponent<Spawn>().enabled = true;
        Enemy.GetComponent<EnemyControl>().enabled = true;
        Enemy2.GetComponent<EnemyControl>().enabled = true;

    }

    public void RepetirRodada()
    {
        SoundController.sounds.click.Play();

        //Para não deletar o username
        PlayerPrefs.DeleteKey("Acertos");
        PlayerPrefs.DeleteKey("Erros");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void voltarParaPrimeiraTela()
    {
        SoundController.sounds.click.Play();

        //Para não deletar o username
        PlayerPrefs.DeleteKey("Acertos");
        PlayerPrefs.DeleteKey("Erros");

        SceneManager.LoadScene("_Inicio");
    }

    public void chamarPanelSair()
    {
        SoundController.sounds.click.Play();

        HUD.SetActive(false);

        GanhouJogoParado();
        panelSair.SetActive(true);
    }

    public void naoSairDoGame()
    {
        SoundController.sounds.click.Play();

        jogoDespausado();

        btnPauseAtivado.SetActive(true);
        btnSair.SetActive(true);

        panelSair.SetActive(false);
    }

    public void sairDoGame() //BOTAO SIM
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
