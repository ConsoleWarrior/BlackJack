using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Sprite[] sprites;
    public int index = 0;
    public int value = 0;

    void Start()
    {
        //Sprite[] sprites = Resources.FindObjectsOfTypeAll<Sprite>();
    }
    public void NewCardAdd()
    {
        Debug.Log("good");
        index = NewUnicIndex();
        GetComponent<SpriteRenderer>().sprite = sprites[index];
        Main.hands.Add(index);
        Main.UpdateScore();
    }
    int NewUnicIndex()
    {
        int nextIndex = Random.Range(0, 52);
        if (Main.hands.Contains(nextIndex)) return NewUnicIndex();
        else return nextIndex;
    }
}

