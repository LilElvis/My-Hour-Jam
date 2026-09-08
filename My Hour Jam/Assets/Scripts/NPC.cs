using UnityEngine;
using UnityEngine.UI;

namespace mhj
{
    public class NPC : MonoBehaviour
    {
        DialogueController DialogueController;
        public Button NpcButton;

        public void Init(DialogueController dialogueController)
        {
            DialogueController = dialogueController;
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
            NpcButton.onClick.AddListener(_npcButtonClickedCallback);
        }

        private void _npcButtonClickedCallback()
        {
            Debug.Log("NPC was clicked!");
        }
    }
}