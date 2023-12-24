using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Text myScoreT;
    public Text scoreAiT;
    public Text resultOfGame;
    public static string message;
    public static int score = 0;
    public static int scoreAI = 0;
    public static List<int> hands;
    public static List<int> handsAI;
    public static int cash = 1000;
    public static int bet = 10;
    public static int win = 0;
    public Text cashT;
    public Text betT;
    public Text winT;
    public static bool isBJ = false;

    void Start()
    {
        hands = new List<int>();
        handsAI = new List<int>();

    }

    void Update()
    {
        myScoreT.text = score.ToString();
        resultOfGame.text = message;
        scoreAiT.text = scoreAI.ToString();
        cashT.text = cash.ToString();
        betT.text = bet.ToString();
        winT.text = win.ToString();
    }
    public void IncreaseBet()
    {
        bet += 10;
    }
    public void DecreaseBet()
    {
        bet -= 10;
        if(bet < 0) bet = 0;
    }
}
