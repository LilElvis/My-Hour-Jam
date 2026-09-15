using UnityEngine;

namespace mhj
{
    public class GameplayController : MonoBehaviour
    {
        public DialogueView DialogueView = null;

        public InspectionView InspectionView = null;

        private DialogueController _dialogueController = new DialogueController();

        private InspectionController _inspectionController = new InspectionController();

        public NPC[] Npcs;
        public OOI[] Oois;

        private async void Start()
        {
            _dialogueController.Init(DialogueView);
            _dialogueController.OnContinuePressed += _onContinuePressedCallback;

            _inspectionController.Init(InspectionView);
            _inspectionController.OnContinuePressed += _onContinuePressedCallback;

            foreach (NPC npc in Npcs)
            {
                npc.Init(_onNpcPressedCallback);
            }

            foreach (OOI ooi in Oois)
            {
                ooi.Init(_onOoiPressedCallback);
            }
        }

        private void _onNpcPressedCallback(DialogueChain dialogueChain)
        {
            _disableInteractions();

            _dialogueController.EvaluateNewDialogueChain(dialogueChain);
        }

        private void _onOoiPressedCallback(InspectionText inspectionObject)
        {
            _disableInteractions();

            _inspectionController.EvaluateNewInspection(inspectionObject);
        }

        private void _onContinuePressedCallback()
        {
            _enableInteractions();
        }

        private void _disableInteractions()
        {
            foreach (NPC npc in Npcs)
            {
                npc.MakeUninteractable();
            }

            foreach (OOI ooi in Oois)
            {
                ooi.MakeUninteractable();
            }
        }

        private void _enableInteractions()
        {
            foreach (NPC npc in Npcs)
            {
                npc.MakeInteractable();
            }

            foreach (OOI ooi in Oois)
            {
                ooi.MakeInteractable();
            }
        }
    }
}


