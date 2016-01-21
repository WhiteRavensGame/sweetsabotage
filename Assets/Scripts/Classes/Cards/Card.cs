using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Card {

    public int cardId;
    public string cardName;
    public CardType cardType;
    public string cardImageLocation;
	
}

public enum CardType
{
    None = -1,
    Staff = 0,
    Customer = 1,
    Dessert = 2,
    Sabotage = 3
}
