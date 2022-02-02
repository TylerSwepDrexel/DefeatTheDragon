using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class CardPositioningEvent : UnityEvent<CardPositioning> { }

	[CreateAssetMenu(
	    fileName = "CardPositioningVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "CardPositioning",
	    order = 120)]
	public class CardPositioningVariable : BaseVariable<CardPositioning, CardPositioningEvent>
	{
	}
}