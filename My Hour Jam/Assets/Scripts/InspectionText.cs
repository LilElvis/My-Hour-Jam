using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    [CreateAssetMenu(fileName = "InspectionText", menuName = "Scriptable Objects/InspectionText")]
    public class InspectionText : ScriptableObject
    {
        public string String = string.Empty;
    }
}