using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStart : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public Button butStart;
    public Button betIn;
    public Button betDe;


    public void ButStartClick()
    {
        Main.score = 0;
        ButtonMore.count = 0;
        Main.hands.Clear();
        Main.message = "";
        Main.isBJ = false;
        card1.GetComponent<Card>().NewCardAdd();
        card2.GetComponent<Card>().NewCardAdd();
        card3.SetActive(false);
        card4.SetActive(false); 
        card5.SetActive(false);
        card6.SetActive(false);
        butStart.interactable = false;
        betDe.interactable = false;
        betIn.interactable = false;
    }
}
