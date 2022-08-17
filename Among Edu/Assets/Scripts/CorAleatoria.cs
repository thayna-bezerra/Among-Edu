using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorAleatoria : MonoBehaviour
{ 
    [Header("Troca cor")]
    public Color corInicial = Color.green;
    Material materialNumero;

    private void Start()
    {
        materialNumero = GetComponent<MeshRenderer>().material;
        materialNumero.color = corInicial;
    }

}
