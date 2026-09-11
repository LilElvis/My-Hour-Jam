using System;
using UnityEngine;
using UnityEngine.UI;

namespace mhj
{
    public class OOI : MonoBehaviour
    {
        private Action<InspectionObject> _onOoiClicked;
        public Button OoiButton;
        public InspectionObject InspectionObject;

        public void Init(Action<InspectionObject> onOoiClicked)
        {
            _onOoiClicked = onOoiClicked;
        }

        public void MakeInteractable()
        {
            OoiButton.interactable = true;
        }

        public void MakeUninteractable()
        {
            OoiButton.interactable = false;
        }

        private void Start()
        {
            OoiButton.onClick.AddListener(_ooiButtonPressedCallback);
        }

        private void _ooiButtonPressedCallback()
        {
            _onOoiClicked?.Invoke(InspectionObject);
        }
    }
}