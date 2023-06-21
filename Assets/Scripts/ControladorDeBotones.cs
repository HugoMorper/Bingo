using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControladorDeBotones : MonoBehaviour
{
    // Start is called before the first frame update
    public NumerosAleatorios _numeroSeleccionado;
    private int counter = 0;
    public Button button;
    void Start()
    {
        _numeroSeleccionado = FindObjectOfType<NumerosAleatorios>();
        button.onClick.AddListener(NumeroCorrecto);    
    }
    
    public void NumeroCorrecto()
    {
        Debug.Log("Presionaste el boton");
        if(_numeroSeleccionado.numeroActual == int.Parse(button.GetComponentInChildren<TMP_Text>().text))
        {
            //GetComponent<Image>().color = Color.blue;
            Debug.Log("Correcto");
            //Deshabilita el boton
        }
        else
        {
            /*GetComponent<Image>().color = Color.red;
            GetComponent<Image>().color = Color.grey;
            counter++;*/
            Debug.Log("No le atinaste");
        }
        if(counter == 2)
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Ya fallaste");
            //Deshabilita el boton
        }

    }
}
