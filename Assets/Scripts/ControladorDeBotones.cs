using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControladorDeBotones : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Sprite grey;
    [SerializeField] private Sprite fail;
    [SerializeField] private Sprite check;
    [SerializeField] private Sprite white;
    public NumerosAleatorios _numeroSeleccionado;
    private int counter = 0;
    public TMP_Text mensaje;
    public Button button;
    int restartaux;
    void Start()
    {
        _numeroSeleccionado = FindObjectOfType<NumerosAleatorios>();
        button.onClick.AddListener(NumeroCorrecto);    
    }
    private void Update() 
    {
        restart();   
    }
    public void NumeroCorrecto()
    {
        if(_numeroSeleccionado.numeroActual == int.Parse(button.GetComponentInChildren<TMP_Text>().text))
        {
            GetComponent<Image>().sprite = check;//blue
            mensaje.text = "Correcto :3";
            //Deshabilita el boton
            button.interactable = false;
        }
        else
        {
            GetComponent<Image>().sprite = grey;//red
            counter++;
            mensaje.text = "No le atinaste D:";
            //wait 
            //GetComponent<Image>().color = Color.white;
        }
        if(counter == 2)
        {
            GetComponent<Image>().sprite = fail;
            mensaje.text = "Ya fallaste unu";
            counter = 0;
            //Deshabilita el boton
            //button.interactable = false;
        }
    }
    private void restart()
    {
        if(_numeroSeleccionado.numeroActual != restartaux)
        {
            if(GetComponent<Image>().sprite != check)
            {
                mensaje.text = "Tu puedes c:";
                GetComponent<Image>().sprite = white;//red
                counter = 0;

            }
        }
        restartaux = _numeroSeleccionado.numeroActual;
        
    }
}
