using UnityEngine;

namespace mhj
{
    [CreateAssetMenu(fileName = "DialogueChainObject", menuName = "Scriptable Objects/DialogueChainObject")]
    public class DialogueChainObject : ScriptableObject
    {
        public Dialogue Dialogue;
    }
}