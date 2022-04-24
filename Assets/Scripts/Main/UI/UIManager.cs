using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        public enum Menu
        {
            START,
            GAME,
            GAME_OVER,
            WIN
        }


        private static UIManager _instance;


        [SerializeField] private GameObject _startPanel;
        [SerializeField] private GameObject _dialogPanel;
        [SerializeField] private GameObject _gameOverPanel;
        [SerializeField] private GameObject _winPanel;

        private Dictionary<Menu, GameObject> _menus;

        public static UIManager Instance => _instance;

        private void Awake()
        {
            _menus = new Dictionary<Menu, GameObject>();
            _menus.Add(Menu.START, _startPanel);
            _menus.Add(Menu.GAME, _dialogPanel);
            _menus.Add(Menu.GAME_OVER, _gameOverPanel);
            _menus.Add(Menu.WIN, _winPanel);


            _instance = this;
            SetMenu(Menu.START);
        }

        public void SetMenu(Menu menu)
        {
            _menus.Where(x => x.Key == menu).Select(x => x.Value).First().SetActive(true);
            _menus.Where(x => x.Key != menu).Select(x => x.Value).ToList().ForEach(x => x.SetActive(false));
        }
    }
}