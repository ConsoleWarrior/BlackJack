using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public Button buttonEnough;
    public Button buttonMore;

    void Start()
    {
        buttonEnough.interactable = false;
        buttonMore.interactable = false;
    }

    public void ButStartClick()
    {
        Main.scoreAI = 0;
        Main.handsAI.Clear();
        card1.GetComponent<Card>().NewCardAddToAI();
        card2.SetActive(false);
        card3.SetActive(false);
        card4.SetActive(false); 
        card5.SetActive(false);
        card6.SetActive(false);
        buttonEnough.interactable = true;
        buttonMore.interactable = true;

    }
    public void TurnAi()
    {
        card2.SetActive(true);
        card2.GetComponent<Card>().NewCardAddToAI();

        if (Main.scoreAI < 16)
        {
            card3.SetActive(true);
            card3.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 16)
        {
            card4.SetActive(true);
            card4.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 16)
        {
            card5.SetActive(true);
            card5.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 16)
        {
            card6.SetActive(true);
            card6.GetComponent<Card>().NewCardAddToAI();
        }
        buttonEnough.interactable = false;
        buttonMore.interactable = false;


    }
}
