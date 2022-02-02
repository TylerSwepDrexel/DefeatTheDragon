using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITakeDamage
{
    public void TakeDamage(GameObject receivedDamager, int receivedAmount);
}