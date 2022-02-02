using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class CallForInterjectionsReference : BaseReference<CallForInterjections, CallForInterjectionsVariable>
	{
	    public CallForInterjectionsReference() : base() { }
	    public CallForInterjectionsReference(CallForInterjections value) : base(value) { }
	}
}