using UnityEngine;
using UnityEngine.SceneManagement;

namespace mhj
{
    public class GameController : MonoBehaviour
    {
        private async void Awake()
        {
            await SceneManager.LoadSceneAsync("menu", LoadSceneMode.Additive);
        }
    }
}


