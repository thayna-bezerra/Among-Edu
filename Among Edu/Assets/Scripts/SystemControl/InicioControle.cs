using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InicioControle : MonoBehaviour
{
    [Header("Panels Principais")]
    public GameObject panelPrimeiraTela;
    public GameObject panelOpcoes;
    public GameObject panelCutscene;

    [Header("Panels Secundarios")]
    public GameObject panelInfo;
    public GameObject panelConfig;
    public GameObject panelSair;

    [Header("Astronautas")]
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;

    public bool Adicao = false;
    public bool Subtracao = false;
    public bool Multiplicacao = false;
    public bool Divisao = false;

    public DontDestroy dd;
    public SoundController soundController;

    private void Start()
    {
       soundController.audioOn = soundController.GetBool("StateAudio");

       panelPrimeiraTela.SetActive(true);
       panelOpcoes.SetActive(false);
       panelCutscene.SetActive(false);

        a1.SetActive(true);
        a2.SetActive(true);
        a3.SetActive(true);

        Adicao = false;
        Subtracao = false;
        Subtracao = false;
        Divisao = false;
    }

    public void irParaPrimeiraTela()
    {
        panelPrimeiraTela.SetActive(true);
        panelOpcoes.SetActive(false);
        panelCutscene.SetActive(false);

        SoundController.sounds.click.Play();
    }

    public void irParaOpcoes()
    {
        panelPrimeiraTela.SetActive(false);
        panelOpcoes.SetActive(true);
        panelCutscene.SetActive(false);

        SoundController.sounds.click.Play();
    }

    public void abrirInformacoes()
    {
        panelPrimeiraTela.SetActive(false);
        panelInfo.SetActive(true);
        SoundController.sounds.click.Play();
    }
    
    public void abrirConfiguracoes()
    {
        panelPrimeiraTela.SetActive(false);
        panelConfig.SetActive(true);

        SoundController.sounds.click.Play();
    }

    public void abrirPanelSair()
    {
        panelPrimeiraTela.SetActive(false);
        panelSair.SetActive(true);

        SoundController.sounds.click.Play();
    }

    public void fecharPanelInfo()
    {
        panelPrimeiraTela.SetActive(true);
        panelInfo.SetActive(false);

        SoundController.sounds.click.Play();
    }

    public void fecharPanelConfig()
    {
        panelPrimeiraTela.SetActive(true);
        panelConfig.SetActive(false);

        SoundController.sounds.click.Play();
    }

    public void naoSairDoGame()
    {
        panelPrimeiraTela.SetActive(true);
        panelSair.SetActive(false);

        SoundController.sounds.click.Play();
    }

    public void sairDoGame() //BOTAO SIM
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

    public void sceneAdicao()
    {
        SoundController.sounds.click.Play();

        StartCoroutine(chamaCutscene());
        Adicao = true;
    }

    public void sceneSubtracao()
    {
        SoundController.sounds.click.Play();

        StartCoroutine(chamaCutscene());
        Subtracao = true;
    }

    public void sceneMultiplicacao()
    {
        SoundController.sounds.click.Play();

        StartCoroutine(chamaCutscene());
        Multiplicacao = true;
    }

    public void sceneDivisao()
    {
        SoundController.sounds.click.Play();

        StartCoroutine(chamaCutscene());
        Divisao = true;
    }

    IEnumerator chamaCutscene()
    {
        playCutscene();

        yield return new WaitForSeconds(4f);

        if (Adicao == true)
            SceneManager.LoadScene("Adicao");
        if(Subtracao == true)
            SceneManager.LoadScene("Subtracao");
        if(Multiplicacao == true)
            SceneManager.LoadScene("Multiplicacao");
        if(Divisao == true)
            SceneManager.LoadScene("Divisao");
    }

    public void playCutscene()
    {
        panelCutscene.SetActive(true);
        panelOpcoes.SetActive(false);
        a1.SetActive(false);
        a2.SetActive(false);
        a3.SetActive(false);
    }
}