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
    public Button betIn;
    public Button betDe;
    public Text winT;
    public AudioManager auman;


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
        auman.SoundPlay1();
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
            auman.SoundPlay1();
            card3.SetActive(true);
            card3.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 17)
        {
            yield return new WaitForSecondsRealtime(2);
            auman.SoundPlay1();
            card4.SetActive(true);
            card4.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 17)
        {
            yield return new WaitForSecondsRealtime(2);
            auman.SoundPlay1();
            card5.SetActive(true);
            card5.GetComponent<Card>().NewCardAddToAI();
        }
        if (Main.scoreAI < 17)
        {
            yield return new WaitForSecondsRealtime(2);
            auman.SoundPlay1();
            card6.SetActive(true);
            card6.GetComponent<Card>().NewCardAddToAI();
        }

        if (Main.scoreAI > 21 && Main.isBJ == false)
        {
            Main.cash += Main.bet;
            Main.win = Main.bet;
            winT.color = Color.green;
            Main.message = "У дилера перебор! Победа твоя!";
        }
        else if (Main.scoreAI > Main.score & Main.scoreAI <= 21)
        {
            Main.cash -= Main.bet;
            Main.win = -Main.bet;
            winT.color = Color.red;
            Main.message = "Победа дилера!";
        }
        else if (Main.scoreAI < Main.score & Main.isBJ)
        {
            Main.cash += (int)(Main.bet * 1.5);
            Main.win = (int)(Main.bet * 1.5);
            winT.color = Color.green;
            Main.message = "У тебя БлэкДжек, у дилера меньше 21! *1.5";
        }
        else if (Main.scoreAI > 21 & Main.isBJ)
        {
            Main.cash += (int)(Main.bet * 1.5);
            Main.win = (int)(Main.bet * 1.5);
            winT.color = Color.green;
            Main.message = "У тебя БлэкДжек, у дилера перебор! *1.5";
        }
        else if (Main.scoreAI < Main.score)
        {
            Main.cash += Main.bet;
            Main.win = Main.bet;
            winT.color = Color.green;
            Main.message = "Победа твоя!";
        }

        else if (Main.scoreAI == Main.score & Main.isBJ & card3.activeSelf == false)
        {
            Main.message = "У обоих BJ! Ничья!";
            Main.win = 0;
            winT.color = Color.white;
        }
        else if (Main.isBJ & Main.scoreAI == Main.score)
        {
            Main.cash += (int)(Main.bet * 1.5);
            Main.win = (int)(Main.bet * 1.5);
            winT.color = Color.green;
            Main.message = "У дилера 21 но не BJ! *1.5";
        }
        else if (Main.scoreAI == Main.score & Main.isBJ == false)
        {
            Main.message = "Ничья";
            Main.win = 0;
            winT.color = Color.white;
        }
        buttonStart.interactable = true;
        betDe.interactable = true;
        betIn.interactable = true;

    }
}
