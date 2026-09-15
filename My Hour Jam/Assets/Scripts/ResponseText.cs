using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    [CreateAssetMenu(fileName = "ResponseText", menuName = "Scriptable Objects/ResponseText")]
    public class ResponseText : ScriptableObject
    {
        public string String = string.Empty;
    }
}