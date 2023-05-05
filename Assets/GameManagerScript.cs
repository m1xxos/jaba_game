using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManagerScript : MonoBehaviour
{
    public List<GameObject> deck = new List<GameObject>();
    public Transform[] cardSlots;
    public bool[] avalibaleCardSlots;
    
    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            GameObject randCard = deck[Random.Range(0, deck.Count)];
            for (int i = 0; i < avalibaleCardSlots.Length; i++)
            {
                if (avalibaleCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    avalibaleCardSlots[i] = false;
                    deck.Remove(randCard);
                    return;
                }
            }
        }
    }
}
