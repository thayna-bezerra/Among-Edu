using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Username : MonoBehaviour
{
    public string userName;
    public GameObject inputField;

    public void getName()
    {
        userName = inputField.GetComponent<InputField>().text;

        Debug.Log("Usuario1: " + userName);

        PlayerPrefs.SetString("User", userName); //Guardar dentro do user
    }
}
