using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioControle : MonoBehaviour
{
    [Header("Panels")]
    public GameObject panelPrimeiraTela;
    public GameObject panelOpcoes;

    private void Start()
    {
       panelPrimeiraTela.SetActive(true);
       panelOpcoes.SetActive(false);
    }

    public void irParaPrimeiraTela()
    {
        panelPrimeiraTela.SetActive(true);
        panelOpcoes.SetActive(false);
    }

    public void irParaOpcoes()
    {
        panelPrimeiraTela.SetActive(false);
        panelOpcoes.SetActive(true);
    }

    public void sceneAdicao()
    {
        SceneManager.LoadScene("Adicao");
    }

    public void sceneSubtracao()
    {
        SceneManager.LoadScene("Subtracao");
    }

    public void sceneMultiplicacao()
    {
        SceneManager.LoadScene("Multiplicacao");
    }

    public void sceneDivisao()
    {
        SceneManager.LoadScene("Divisao");
    }
}
