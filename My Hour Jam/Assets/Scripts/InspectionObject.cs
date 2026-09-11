using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    [CreateAssetMenu(fileName = "InspectionObject", menuName = "Scriptable Objects/InspectionObject")]
    public class InspectionObject : ScriptableObject
    {
        public string InspectionText;
    }
}