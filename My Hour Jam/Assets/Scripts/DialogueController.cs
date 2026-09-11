using System;

namespace mhj
{
    public class DialogueController
    {
        public Action OnContinuePressed;

        public bool DialogueInProgress
        {
            get
            {
                return _currentDialogueChain != null;
            }
        }

        private DialogueView _dialogueView;
        private DialogueChainObject _currentDialogueChain = null;
        private Dialogue _currentDialogue = null;

        public void Init(DialogueView dialogueView)
        {
            _dialogueView = dialogueView;
        }

        public void EvaluateNewDialogueChain(DialogueChainObject dialogueChain)
        {
            _currentDialogueChain = dialogueChain;

            _dialogueView.Show();

            _currentDialogue = _currentDialogueChain.Dialogue;

            _updateDialogueView();
        }

        private void _updateDialogueView()
        {
            _dialogueView.ClearAllDialogueResponseOptions();

            _dialogueView.SetDialogueText(_currentDialogue.DialogObject.DialogueText);

            if (_currentDialogue.Responses.Length > 0)
            {
                foreach (Response response in _currentDialogue.Responses)
                {
                    _dialogueView.CreateDialogueResponseOption(response.ResponseObject, () => { _onResponsePressedCallback(response.NextDialogue); });
                }
            }
            else
            {
                _dialogueView.CreateContinueOption(() => { _onContinuePressedCallback(); });
            }
        }

        private void _onResponsePressedCallback(Dialogue dialogue)
        {
            _currentDialogue = dialogue;

            _updateDialogueView();
        }

        private void _onContinuePressedCallback()
        {
            _currentDialogue = null;

            _currentDialogueChain = null;

            _dialogueView.Hide();

            OnContinuePressed.Invoke();
        }
    }
}