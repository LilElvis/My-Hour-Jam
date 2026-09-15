using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    [CreateAssetMenu(fileName = "Response", menuName = "Scriptable Objects/Response")]
    public class Response : ScriptableObject
    {
        [SerializeReference] public ResponseText ResponseText = null;
        [SerializeReference] public Dialogue NextDialogue = new Dialogue();
    }
}