using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "CallForInterjections")]
	public sealed class CallForInterjectionsGameEventListener : BaseGameEventListener<CallForInterjections, CallForInterjectionsGameEvent, CallForInterjectionsUnityEvent>
	{
	}
}