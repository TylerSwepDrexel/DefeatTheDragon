using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InteractionType { Damage, Block, Draw, Mana, Status };
[System.Serializable]
public class CallForInterjections
{
    public GameObject initiator;
    public GameObject target;
    public InteractionType typeOfInteraction;
    public InterjectionProcessor processor;

    public CallForInterjections(GameObject receivedInitiator, GameObject receivedTarget, InteractionType receivedInteractionType, InterjectionProcessor receivedProcessor)
    {
        initiator = receivedInitiator;
        target = receivedTarget;
        typeOfInteraction = receivedInteractionType;
        processor = receivedProcessor;
    }
}