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
    public int totalContas;

    public Text textAcertos;
    public Text textErros;

    public bool encontrouResposta = false;
    public bool respostaErrada = false;

    public GameObject panelFinal;

    private void Start()
    {
        panelFinal.SetActive(false);
    }

    private void Update()
    {
        totalAcertos = PlayerPrefs.GetInt("Acertos");
        totalErros = PlayerPrefs.GetInt("Erros");

        textAcertos.text = totalAcertos.ToString();
        textErros.text = totalErros.ToString();

        totalContas = totalAcertos + totalErros;

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

        //acertosPanel.text = totalAcertos.ToString();
        //errosPanel.text = totalErros.ToString();

        //fazer condição de media do total de erros e acertos
        //textText.text = finalText.ToString("Vc é incrivel"); 
        //textText.text = finalText.ToString("Tente novamente"); 
    }

}
