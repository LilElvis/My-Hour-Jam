using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace mhj
{
    public class DialogueView : MonoBehaviour
    {
        public GameObject DialogueViewHandle;
        public TMP_Text DialogueText;
        public Transform DialogueResponseHandle;
        public GameObject DialogueResponseOptionPrefab;

        public void Show()
        {
            DialogueViewHandle.SetActive(true);
        }

        public void Hide()
        {
            DialogueViewHandle.SetActive(false);
        }

        public void SetDialogueText(string dialogue)
        {
            DialogueText.text = dialogue;
        }

        public void CreateDialogueResponseOption(ResponseObject responseObject, Action onResponsePressed)
        {
            var option = Instantiate(DialogueResponseOptionPrefab, DialogueResponseHandle);
            var responseText = option.GetComponentInChildren<TMP_Text>();
            responseText.text = responseObject.ResponseText;
            var responseButton = option.GetComponent<Button>();
            responseButton.onClick.AddListener(() => { onResponsePressed?.Invoke(); });
        }

        public void CreateContinueOption(Action onContinuePressed)
        {
            var option = Instantiate(DialogueResponseOptionPrefab, DialogueResponseHandle);
            var responseText = option.GetComponentInChildren<TMP_Text>();
            responseText.text = "(Continue.)";
            var responseButton = option.GetComponent<Button>();
            responseButton.onClick.AddListener(() => { onContinuePressed?.Invoke(); });
        }

        public void ClearAllDialogueResponseOptions()
        {
            foreach (Transform child in DialogueResponseHandle)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }
}