using TMPro;
using UnityEngine;

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

        public void CreateDialogueResponseOptions()
        {
            ClearAllDialogueResponseOptions();

            var option = Instantiate(DialogueResponseOptionPrefab, DialogueResponseHandle);
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