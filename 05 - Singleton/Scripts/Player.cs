using System;

namespace SingletonDesignPattern
{
    public sealed class Player
    {
        public static Player Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Player();
                }
                return _instance;
            }
        }

        private static Player _instance;

        private Player()
        {
        }

        private int _health = 100;
        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                OnHealthchange?.Invoke(_health);
            }
        }
        public Action<int> OnHealthchange;
    }
}