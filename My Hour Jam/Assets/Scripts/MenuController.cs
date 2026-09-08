using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace mhj
{
    public class MenuController : MonoBehaviour
    {
        public Button StartButton;
        public Button ExittButton;


        void Awake()
        {
            StartButton.onClick.AddListener(_onStartButtonPressedCallback);
            ExittButton.onClick.AddListener(_onExitButtonPressedCallback);
        }

        void Update()
        {

        }

        private async void _onStartButtonPressedCallback()
        {
            await SceneManager.LoadSceneAsync("gameplay", LoadSceneMode.Additive);

            await SceneManager.UnloadSceneAsync("menu");
        }

        private void _onExitButtonPressedCallback()
        {
            Application.Quit();
        }
    }
}
