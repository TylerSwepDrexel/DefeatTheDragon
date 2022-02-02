using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventCardDraw : Status
{
    public void InterceptCardDrawMessage(CallForInterjections theInterjection)
    {
        if (theInterjection.typeOfInteraction == InteractionType.Draw)
        {
            theInterjection.processor.ReceiveSetter(this.gameObject, 0);
        }
    }
}
