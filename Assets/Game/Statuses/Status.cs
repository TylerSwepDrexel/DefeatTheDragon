using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class Status : MonoBehaviour
{
    public int duration;
    public GameObject statusOwner;
    public GameObjectGameEvent onStatusApplied;
    public GameObjectGameEvent onStatusUpdated;

    public virtual void MoveToCorrectPosition()
    {

    }
}
