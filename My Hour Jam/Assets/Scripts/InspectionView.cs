using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace mhj
{
    public class InspectionView : MonoBehaviour
    {
        public GameObject InspectionViewHandle;
        public TMP_Text InspectionText;
        public Button ContinueButton;

        public void Show()
        {
            InspectionViewHandle.SetActive(true);
        }

        public void Hide()
        {
            InspectionViewHandle.SetActive(false);
        }

        public void SetInspectionText(string dialogue)
        {
            InspectionText.text = dialogue;
        }

        public void CreateContinueOption(Action onContinuePressed)
        {
            ContinueButton.onClick.AddListener(() => { onContinuePressed?.Invoke(); });
        }
    }
}