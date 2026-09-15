using UnityEngine;

namespace mhj
{
    [CreateAssetMenu(fileName = "DialogueChain", menuName = "Scriptable Objects/DialogueChain")]
    public class DialogueChain : ScriptableObject
    {
        [SerializeReference] public Dialogue Dialogue = new Dialogue();
    }
}