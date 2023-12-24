using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Card : MonoBehaviour
{
    public Sprite[] sprites;
    public int index = 0;
    public int value = 0;

    int NewUnicIndex() //новый индекс карты в колоде
    {
        int nextIndex = Random.Range(0, 52);
        if (Main.hands.Contains(nextIndex) || Main.handsAI.Contains(nextIndex)) return NewUnicIndex();
        else return nextIndex;
    }
    public void NewCardAdd()
    {
        index = NewUnicIndex();
        GetComponent<SpriteRenderer>().sprite = sprites[index];
        Main.hands.Add(index);
        UpdateScore();
    }
    public void NewCardAddToAI()
    {
        index = NewUnicIndex();
        GetComponent<SpriteRenderer>().sprite = sprites[index];
        Main.handsAI.Add(index);
        UpdateScoreAI();
    }

    void UpdateScore()
    {
        //int value = 0; 
        int tempScore = 0;
        List<int> valuesHands = new List<int>();
        foreach (var item in Main.hands)
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
        if (tempScore > 21)
        {
            bool firstAce = true;
            for (int i = 0; i < valuesHands.Count; i++)
            {
                if (valuesHands[i] == 11 & firstAce)
                {
                    valuesHands[i] = 1;
                    tempScore -= 10;
                    firstAce = false;
                }
            }
            if (tempScore > 21)
            {
                firstAce = true;
                for (int i = 0; i < valuesHands.Count; i++)
                {
                    if (valuesHands[i] == 11 & firstAce)
                    {
                        valuesHands[i] = 1;
                        tempScore -= 10;
                        firstAce = false;
                    }
                }
            }
        }
        Main.score = tempScore;
    }


    void UpdateScoreAI()
    {
        int tempScore = 0;
        List<int> valuesHands = new List<int>();
        foreach (var item in Main.handsAI)
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
        if (tempScore > 21)
        {
            bool firstAce = true;
            for (int i = 0; i < valuesHands.Count; i++)
            {
                if (valuesHands[i] == 11 & firstAce)
                {
                    valuesHands[i] = 1;
                    tempScore -= 10;
                    firstAce = false;
                }
            }
            if(tempScore > 21)
            {
                firstAce = true;

                for (int i = 0; i < valuesHands.Count; i++)
                {
                    if (valuesHands[i] == 11 & firstAce)
                    {
                        valuesHands[i] = 1;
                        tempScore -= 10;
                        firstAce = false;
                    }
                }
            }

        }
        Main.scoreAI = tempScore;
    }
}

