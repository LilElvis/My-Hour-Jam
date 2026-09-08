using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    public class Dialogue
    {
        [SerializeReference]
        public DialogueObject DialogObject;
        public Response[] Responses;
    }
}