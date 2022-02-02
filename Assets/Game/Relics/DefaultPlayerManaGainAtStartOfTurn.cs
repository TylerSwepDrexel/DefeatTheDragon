using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class DefaultPlayerManaGainAtStartOfTurn : MonoBehaviour
{
    public IntVariable playerManaVariable;
    public int amountOfManaThePlayerStartsEachTurnWith;


    public GameEvent startPlayerTurn;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            startPlayerTurn.Raise();
        }
    }
    public void OnPlayerTurnStart()
    {
        playerManaVariable.Value = amountOfManaThePlayerStartsEachTurnWith;
    }
}