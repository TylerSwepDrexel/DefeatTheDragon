using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "CallForInterjectionsGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "CallForInterjections",
	    order = 120)]
	public sealed class CallForInterjectionsGameEvent : GameEventBase<CallForInterjections>
	{
	}
}