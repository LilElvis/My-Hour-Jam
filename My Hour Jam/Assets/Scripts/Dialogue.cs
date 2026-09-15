using System;
using UnityEngine;

namespace mhj
{
    [Serializable]
    public class Dialogue
    {
        [SerializeReference] public DialogueText DialogueText = null;
        public Response[] Responses = new Response[0];
    }
}