using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Sprite[] sprites;
    public int index = 0;
    public int value = 0;

    public void NewCardAdd()
    {
        index = NewUnicIndex();
        GetComponent<SpriteRenderer>().sprite = sprites[index];
        Main.hands.Add(index);
        Main.UpdateScore();
    }
    int NewUnicIndex() //новый индекс карты в колоде
    {
        int nextIndex = Random.Range(0, 52);
        if (Main.hands.Contains(nextIndex)||Main.handsAI.Contains(nextIndex)) return NewUnicIndex();
        else return nextIndex;
    }
        public void NewCardAddToAI()
    {
        index = NewUnicIndex();
        GetComponent<SpriteRenderer>().sprite = sprites[index];
        Main.handsAI.Add(index);
        Main.UpdateScoreAI();
    }
}

