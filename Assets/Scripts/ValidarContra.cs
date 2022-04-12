using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string ContraCorrecta;
    string ContraUsr;
    public Text inputUsr;
    public Text txtMsg;
    public GameObject cartelMsg;

    // Start is called before the first frame update
    void Start()
    {
        ContraCorrecta = "12345";
        cartelMsg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContra()
    {
        ContraUsr = inputUsr.text;
        cartelMsg.SetActive(true);

        if (ContraUsr == ContraCorrecta)
        {
            Debug.Log("Bienvenido");
            txtMsg.text = "Bienvenido";
        }

        else
        {
            Debug.Log("Contraseña incorrecta");
            txtMsg.text = "Contraseña incorrecta";
        }
    }
}
