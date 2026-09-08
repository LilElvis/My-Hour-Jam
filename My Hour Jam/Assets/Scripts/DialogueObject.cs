using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    [CreateAssetMenu(fileName = "DialogueObject", menuName = "Scriptable Objects/DialogueObject")]
    public class DialogueObject : ScriptableObject
    {
        public string DialogueText;
    }
}