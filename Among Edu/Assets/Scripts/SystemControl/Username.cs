using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Username : MonoBehaviour
{
    [Header("UserName")]
    public string userName;
    public GameObject inputField;

    [Header("URL para Recompensa")]
    public string url;
    public GameObject inputFieldURL;

    public void getName()
    {
        userName = inputField.GetComponent<InputField>().text;
        url = inputFieldURL.GetComponent<InputField>().text;

        Debug.Log("Usuario1: " + userName);

        PlayerPrefs.SetString("User", userName); //Guardar dentro do user
        PlayerPrefs.SetString("URL", url); //Guardar url
    }
}
