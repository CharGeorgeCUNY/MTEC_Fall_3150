using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardSuit
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}

[CreateAssetMenu(fileName = "CardData", menuName = "Card Game/Card Data")]
public class Card : MonoBehaviour
{
    public CardSuit suit;
    public int rank;
    public Sprite cardSprite;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
