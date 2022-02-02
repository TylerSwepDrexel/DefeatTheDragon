using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardPositioning
{
    public Vector2 xPositionRange;
    public float yPosition;
    public float xPositionIncreasePerCard;

    public CardPositioning(Vector2 receivedXRange, float receivedYPos, float receivedXPosIncreasePerCard)
    {
        xPositionRange = receivedXRange;
        yPosition = receivedYPos;
        xPositionIncreasePerCard = receivedXPosIncreasePerCard;
    }
}
