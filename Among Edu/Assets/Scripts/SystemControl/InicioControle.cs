using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioControle : MonoBehaviour
{
    [Header("Panels")]
    public GameObject panelPrimeiraTela;
    public GameObject panelOpcoes;
    public GameObject panelCutscene;

    [Header("Astronautas")]
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;

    public bool Adicao = false;
    public bool Subtracao = false;
    public bool Multiplicacao = false;
    public bool Divisao = false;

    private void Start()
    {
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
    }

    public void irParaOpcoes()
    {
        panelPrimeiraTela.SetActive(false);
        panelOpcoes.SetActive(true);
        panelCutscene.SetActive(false);
    }

    public void sceneAdicao()
    {
        StartCoroutine(chamaCutscene());
        Adicao = true;
    }

    public void sceneSubtracao()
    {
        StartCoroutine(chamaCutscene());
        Subtracao = true;
    }

    public void sceneMultiplicacao()
    {
        StartCoroutine(chamaCutscene());
        Multiplicacao = true;
    }

    public void sceneDivisao()
    {
        StartCoroutine(chamaCutscene());
        Divisao = true;
    }

    IEnumerator chamaCutscene()
    {
        playCutscene();

        yield return new WaitForSeconds(4f); 

        if(Adicao == true)
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
