using System;
using UnityEngine;
using UnityEngine.UI;

namespace mhj
{
    public class NPC : MonoBehaviour
    {
        private Action<DialogueChain> _onNpcClicked;
        public Button NpcButton;
        public DialogueChain DialogueChain;

        public void Init(Action<DialogueChain> onNpcClicked)
        {
            _onNpcClicked = onNpcClicked;
        }

        public void MakeInteractable()
        {
            NpcButton.interactable = true;
        }

        public void MakeUninteractable()
        {
            NpcButton.interactable = false;
        }

        private void Start()
        {
            NpcButton.onClick.AddListener(_npcButtonPressedCallback);
        }

        private void _npcButtonPressedCallback()
        {
            _onNpcClicked?.Invoke(DialogueChain);
        }
    }
}