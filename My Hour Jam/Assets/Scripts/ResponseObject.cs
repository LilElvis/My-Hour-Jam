using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    [CreateAssetMenu(fileName = "ResponseObject", menuName = "Scriptable Objects/ResponseObject")]
    public class ResponseObject : ScriptableObject
    {
        public string ResponseText;
    }
}