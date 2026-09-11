using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    public class Inspection
    {
        [SerializeReference]
        public InspectionObject InspectionObject;
    }
}