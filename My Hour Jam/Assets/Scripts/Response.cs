
using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    public class Response
    {
        [SerializeReference]
        public ResponseObject ResponseObject;
        public Dialogue NextDialogue;
    }
}