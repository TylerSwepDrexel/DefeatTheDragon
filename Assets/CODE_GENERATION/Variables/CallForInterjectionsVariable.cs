using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class CallForInterjectionsEvent : UnityEvent<CallForInterjections> { }

	[CreateAssetMenu(
	    fileName = "CallForInterjectionsVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "CallForInterjections",
	    order = 120)]
	public class CallForInterjectionsVariable : BaseVariable<CallForInterjections, CallForInterjectionsEvent>
	{
	}
}