using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class RoundsCounter : MonoBehaviour
{
    [Header("Variáveis de erros e acertos")]
    public int totalAcertos;
    public int totalErros;
    public float totalContas;

    public Text textAcertos;
    public Text textErros;

    public Text panelTextAcertos;
    public Text panelTextErros;

    public Text textFinal;
    public string username;

    public bool encontrouResposta = false;
    public bool respostaErrada = false;

    public GameObject panelFinal;

    public Controle controle;

    [Header("PROGRESSO")]
    public Image barraProgressoRodadas;
    public float totalRodadas; //recebe totalcontas
    public int qtdRodadas;


    private void Start()
    {
        panelFinal.SetActive(false);
    }

    private void Update()
    {

        totalAcertos = PlayerPrefs.GetInt("Acertos");
        totalErros = PlayerPrefs.GetInt("Erros");

        textAcertos.text = totalAcertos.ToString(totalAcertos + " /");
        textErros.text = totalErros.ToString();

        totalContas = totalAcertos + totalErros;
        totalRodadas = totalContas/10;
        barraProgressoRodadas.fillAmount = totalRodadas;

        if (encontrouResposta == true && totalContas <= 10)
            StartCoroutine(ChamarNovaRodada());

        else if (totalContas >= 10)
            ChamaPanel();
    }

    IEnumerator ChamarNovaRodada()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ChamaPanel()
    {
        panelFinal.SetActive(true);

        textAcertos.enabled = false;
        textErros.enabled = false;

        controle.GanhouJogoParado();

        panelTextAcertos.text = ("Total Acertos: " + totalAcertos);
        panelTextErros.text = ("Total Erros: " + totalErros);

        username = PlayerPrefs.GetString("User"); //pegando dado salvo no "user" e aplicando noutra variavel

        if (totalAcertos >= 6)
            textFinal.text = ("Parabéns!\r\nVocê é incrível " + username + "!");
        else
            textFinal.text = ("Não desista " + username + "!" + "\r\nVamos tentar novamente?"); 
    }
}
