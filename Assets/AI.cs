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
    public Button buttonStart;


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
        buttonStart.interactable = false;
        card2.SetActive(true);
        card2.GetComponent<Card>().NewCardAddToAI();
        StartCoroutine(AiPause());

        buttonEnough.interactable = false;
        buttonMore.interactable = false;

    }
    IEnumerator AiPause()
    {
        if (Main.scoreAI < 17)
        {
            yield return new WaitForSecondsRealtime(2);
            card3.SetActive(true);
            card3.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 17)
        {
            yield return new WaitForSecondsRealtime(2);
            card4.SetActive(true);
            card4.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 17)
        {
            yield return new WaitForSecondsRealtime(2);
            card5.SetActive(true);
            card5.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 17)
        {
            yield return new WaitForSecondsRealtime(2);
            card6.SetActive(true);
            card6.GetComponent<Card>().NewCardAddToAI();
        }

        if (Main.scoreAI > 21 && Main.isBJ == false)
        {
            Main.cash += Main.bet;
            Main.win = Main.bet;
            Main.message = "У дилера перебор! Победа твоя!";
        }
        else if (Main.scoreAI > Main.score)
        {
            Main.cash -= Main.bet;
            Main.win = -Main.bet;
            Main.message = "Победа дилера!";
        }
        else if (Main.scoreAI < Main.score & Main.isBJ)
        {
            Main.cash += (int)(Main.bet * 1.5);
            Main.win = (int)(Main.bet * 1.5);
            Main.message = "У тебя БлэкДжек, у дилера меньше! *1.5";
        }
        else if (Main.scoreAI > 21 & Main.isBJ)
        {
            Main.cash += (int)(Main.bet * 1.5);
            Main.win = (int)(Main.bet * 1.5);
            Main.message = "У тебя БлэкДжек, у дилера перебор! *1.5";
        }
        else if (Main.scoreAI < Main.score)
        {
            Main.cash += Main.bet;
            Main.win = Main.bet;
            Main.message = "Победа твоя!";
        }

        else if (Main.scoreAI == Main.score & Main.isBJ & card3.activeSelf == false)
        {
            Main.message = "У обоих BJ! Ничья!";
            Main.win = 0;
        }
        else if (Main.isBJ & Main.scoreAI == Main.score)
        {
            Main.cash += (int)(Main.bet * 1.5);
            Main.win = (int)(Main.bet * 1.5);
            Main.message = "У дилера 21 но нет BJ! *1.5";
        }
        else if (Main.scoreAI == Main.score & Main.isBJ == false)
        {
            Main.message = "Ничья";
            Main.win = 0;
        }
        buttonStart.interactable = true;

    }
}
