using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    [CreateAssetMenu(fileName = "DialogueText", menuName = "Scriptable Objects/DialogueText")]
    public class DialogueText : ScriptableObject
    {
        public string String = string.Empty;
    }
}