using System;

namespace mhj
{
    public class InspectionController
    {
        public Action OnContinuePressed;

        public bool InspectionInProgress
        {
            get
            {
                return _currentInspectionObject != null;
            }
        }

        private InspectionView _inspectionView;
        private InspectionText _currentInspectionObject = null;

        public void Init(InspectionView inspectionView)
        {
            _inspectionView = inspectionView;
        }

        public void EvaluateNewInspection(InspectionText inspectionObject)
        {
            _currentInspectionObject = inspectionObject;

            _inspectionView.Show();

            _updateInspectionView();
        }

        private void _updateInspectionView()
        {
            _inspectionView.SetInspectionText(_currentInspectionObject.String);

            _inspectionView.CreateContinueOption(() => { _onContinuePressedCallback(); });
        }

        private void _onContinuePressedCallback()
        {
            _currentInspectionObject = null;

            _inspectionView.Hide();

            OnContinuePressed.Invoke();
        }
    }
}