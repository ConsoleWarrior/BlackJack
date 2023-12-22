using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMore : MonoBehaviour
{
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public static int count = 0;
    public void ActiveNextCard()
    {
        switch (count)
        {
            case 0:card3.SetActive(true); card3.GetComponent<Card>().NewCardAdd(); break;
            case 1:card4.SetActive(true); card4.GetComponent<Card>().NewCardAdd(); break;
            case 2:card5.SetActive(true); card5.GetComponent<Card>().NewCardAdd(); break;
            case 3:card6.SetActive(true); card6.GetComponent<Card>().NewCardAdd(); break;
        }
        count++;
    }
}
