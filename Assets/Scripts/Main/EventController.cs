using System;
using UnityEngine;

namespace Main
{
    public class EventController : MonoBehaviour
    {
        private static EventController instance;

        public static EventController Instance => instance;

        private void Awake()
        {
            instance = this;
        }
    }
}