using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vulnerable : Status
{
    public float multiplier;

    public void ReceiveInterjectionCall(CallForInterjections receivedCall)
    {
        if (receivedCall.target == statusOwner)
        {
            if (receivedCall.typeOfInteraction == InteractionType.Damage)
            {
                receivedCall.processor.ReceiveMultiplier(this.gameObject, multiplier);
            }
        }
    }
}