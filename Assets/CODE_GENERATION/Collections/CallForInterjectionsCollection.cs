using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "CallForInterjectionsCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "CallForInterjections",
	    order = 120)]
	public class CallForInterjectionsCollection : Collection<CallForInterjections>
	{
	}
}