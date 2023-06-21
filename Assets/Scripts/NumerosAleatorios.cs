/*
    Script que se encarga de la generacion de numeros aleatorios que simulan las pelotas que salen de la tombola del bingo
*/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumerosAleatorios : MonoBehaviour
{
    public int numeroActual = 0;//Variable publica para poder verificar el numero que salio
    public TMP_Text randomNumber;
    public Button button;
    [SerializeField] private List<int> invalidNumbers = new List<int>(){0,1,2,3,4,5,6,7,8,9,10,11,12,13,14};
    [SerializeField] private int tamList ;//Variable que indica el limite superior permitido en el random 
    private int numAux = 0;
    
    private void Start() 
    {
        tamList = invalidNumbers.Count;
        button.onClick.AddListener(RandomNumber);   
    }
    void RandomNumber()
    {
        numAux = Random.Range(0,tamList);
        randomNumber.text = invalidNumbers[numAux].ToString();
        numeroActual = invalidNumbers[numAux]; Debug.Log("Numero Actual:"+numeroActual);
        invalidNumbers.RemoveAt(numAux);
        tamList--;
    }
    
}
