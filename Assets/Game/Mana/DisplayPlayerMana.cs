using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;

public class DisplayPlayerMana : MonoBehaviour
{
    public TextMeshPro myText;
    public IntVariable playerManaVariable;

    public void UpdateManaDisplay()
    {
        myText.text = playerManaVariable.Value.ToString();
    }
}