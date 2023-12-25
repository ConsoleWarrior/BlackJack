using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMore : MonoBehaviour
{
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public static int count = 0;
    public Button buttonEnough;
    public Button buttonMore;
    public Button buttonStart;
    public GameObject card1AI;
    public Text winT;
    public Button betIn;
    public Button betDe;

    public void ActiveNextCard()
    {
        switch (count)
        {
            case 0:card3.SetActive(true); card3.GetComponent<Card>().NewCardAdd(); MessageAfterNewCard(); break;
            case 1:card4.SetActive(true); card4.GetComponent<Card>().NewCardAdd(); MessageAfterNewCard(); break;
            case 2:card5.SetActive(true); card5.GetComponent<Card>().NewCardAdd(); MessageAfterNewCard(); break;
            case 3:card6.SetActive(true); card6.GetComponent<Card>().NewCardAdd(); MessageAfterNewCard(); break;
        }
        count++;
    }
    public void MessageAfterNewCard()
    {
        if(Main.score > 21)
        {
            Main.message = "Перебор!";
            Main.cash -= Main.bet;
            Main.win = -Main.bet;
            winT.color = Color.red;
            buttonMore.interactable = false; 
            buttonEnough.interactable = false;
            buttonStart.interactable = true;
            betDe.interactable = true;
            betIn.interactable = true;
        }
        if (Main.score == 21 && card3.activeSelf==false)
        {
            Main.message = "Блэк Джек!";
            Main.isBJ = true;
            buttonStart.interactable = false; 
            buttonMore.interactable = false; 
            if(card1AI.GetComponent<Card>().value == 10 || card1AI.GetComponent<Card>().value == 11)
            buttonEnough.onClick.Invoke();
            else
            {
                Main.message = "Блэк Джек! Твоя Победа!";
                Main.cash += (int)(Main.bet * 1.5);
                Main.win = (int)(Main.bet*1.5);
                winT.color = Color.green;
                buttonStart.interactable = true;
                buttonEnough.interactable = false;
                betDe.interactable = true;
                betIn.interactable = true;
            }
        }
        if (Main.score == 21 & card3.activeSelf)
        {
            Main.message = "У вас 21! Ход дилера!";
            buttonStart.interactable = false;
            buttonMore.interactable = false;
            buttonEnough.onClick.Invoke();
        }
    }
}
