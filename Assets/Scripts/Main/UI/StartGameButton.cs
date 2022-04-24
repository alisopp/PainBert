using Main;
using UnityEngine;

namespace UI
{
    public class StartGameButton : MonoBehaviour
    {
        public void StartGame()
        {
            DialogController.Instance.StartDialog();
            UIManager.Instance.SetMenu(UIManager.Menu.GAME);
            
        }
    }
}