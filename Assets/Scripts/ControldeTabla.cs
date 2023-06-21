using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControldeTabla : MonoBehaviour
{
    // Start is called before the first frame update
    public NumerosAleatorios _numeroSeleccionado;
    public GameObject Carta;
    
    [SerializeField] private List<Button> ColeccionDeBotones = new List<Button>();
    [SerializeField] private List<string> ColeccionDeCartas = new List<string>()
                    {   "texto1","texto2","texto3","texto4","texto5","texto6","texto7","texto8",
                        "texto9","texto10","texto11","texto12","texto13","texto14","texto15"
                    };//{mucho texto};//Lista de cartas
    void Start()
    {
        _numeroSeleccionado = FindObjectOfType<NumerosAleatorios>();
        for(int i = 0; i<15; i++)
        {
            ColeccionDeBotones[i].GetComponentInChildren<TMP_Text>().text = Random.Range(0,15).ToString();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        SacaCarta();
    }
    private void SacaCarta()
    {
        //Termina animacion
        Carta.SetActive(true);
        Carta.GetComponentInChildren<TMP_Text>().text = ColeccionDeCartas[_numeroSeleccionado.numeroActual];
    }
    
}
