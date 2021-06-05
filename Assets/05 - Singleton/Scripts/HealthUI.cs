using System;
using UnityEngine;
using UnityEngine.UI;

namespace SingletonDesignPattern
{
    public class HealthUI : MonoBehaviour
    {
        public Text health;

        private void Start()
        {
            Player.Instance.OnHealthchange += HandleHealthChange;
        }

        private void HandleHealthChange(int amount)
        {
            health.text = $"HEALTH: {amount}";
        }
    }
}