using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Text myScore;
    public static int score = 0;
    public static List<int> hands;
    void Start()
    {
        hands = new List<int>();
    }


    void Update()
    {
        myScore.text = score.ToString();

    }
    
    public static void UpdateScore()
    {
        int value = 0; int tempScore = 0;
        List<int> valuesHands = new List<int>();
        foreach (var item in hands)
        {
            switch (item % 13)
            {
                case 0: value = 11; break;
                case 1: value = 2; break;
                case 2: value = 3; break;
                case 3: value = 4; break;
                case 4: value = 5; break;
                case 5: value = 6; break;
                case 6: value = 7; break;
                case 7: value = 8; break;
                case 8: value = 9; break;
                case 9: value = 10; break;
                case 10: value = 10; break;
                case 11: value = 10; break;
                case 12: value = 10; break;
            }
            valuesHands.Add(value);
            tempScore += value;
        }
        if (tempScore > 21)         //ищем тузы
        {
            //if (hands.Contains(0)|| hands.Contains(13)|| hands.Contains(26)|| hands.Contains(39)) Debug.Log("0,13,26,39");
            for(int i=0; i<valuesHands.Count;i++)
            {
                if (valuesHands[i] == 11)
                {
                    valuesHands[i] = 1;
                    tempScore -= 10;
                }
            }
        }

        //if (value == 11 & Main.score + value > 21) value = 1;
        score = tempScore;
    } 
}
