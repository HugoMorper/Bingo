using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public ControldeTabla _ct;
    [SerializeField] private TMP_Text B;
    [SerializeField] private TMP_Text I;
    [SerializeField] private TMP_Text N;
    [SerializeField] private TMP_Text G;
    [SerializeField] private TMP_Text O;
    // Start is called before the first frame update
    void Start()
    {
        _ct = FindObjectOfType<ControldeTabla>();
    }

    // Update is called once per frame
    void Update()
    {
        Victory();
    }

    public void Victory()
    {
        if(_ct.ColeccionDeBotones[0].interactable == false && _ct.ColeccionDeBotones[1].interactable == false && _ct.ColeccionDeBotones[2].interactable == false && _ct.ColeccionDeBotones[3].interactable == false && _ct.ColeccionDeBotones[4].interactable == false &&_ct.ColeccionDeBotones[5].interactable == false && _ct.ColeccionDeBotones[6].interactable == false && _ct.ColeccionDeBotones[7].interactable == false && _ct.ColeccionDeBotones[8].interactable == false && _ct.ColeccionDeBotones[9].interactable == false && _ct.ColeccionDeBotones[10].interactable == false && _ct.ColeccionDeBotones[11].interactable == false && _ct.ColeccionDeBotones[12].interactable == false && _ct.ColeccionDeBotones[13].interactable == false && _ct.ColeccionDeBotones[14].interactable == false)
        {
            Debug.Log("Ganaste");
        }

        if(_ct.ColeccionDeBotones[0].interactable == false && _ct.ColeccionDeBotones[5].interactable == false && _ct.ColeccionDeBotones[10].interactable == false)
        {
            B.text = "B";
        }
        if(_ct.ColeccionDeBotones[1].interactable == false && _ct.ColeccionDeBotones[6].interactable == false && _ct.ColeccionDeBotones[11].interactable == false)
        {
            I.text = "I";
        }
        if(_ct.ColeccionDeBotones[2].interactable == false && _ct.ColeccionDeBotones[7].interactable == false && _ct.ColeccionDeBotones[12].interactable == false)
        {
            N.text = "N";
        }
        if(_ct.ColeccionDeBotones[3].interactable == false && _ct.ColeccionDeBotones[8].interactable == false && _ct.ColeccionDeBotones[13].interactable == false)
        {
            G.text = "G";
        }
        if(_ct.ColeccionDeBotones[4].interactable == false && _ct.ColeccionDeBotones[9].interactable == false && _ct.ColeccionDeBotones[14].interactable == false)
        {
            O.text = "O";
        }
    
    }
}
