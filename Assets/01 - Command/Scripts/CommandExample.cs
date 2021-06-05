using System.Collections.Generic;
using UnityEngine;

namespace CommandDesignPattern
{
    public class CommandExample : MonoBehaviour
    {
        [SerializeField] private bool _loop = false;
        [SerializeField] private GameplayCommand[] _commands = default;

        private GameplayCommand _command;
        private readonly Queue<GameplayCommand> _commandQueue = new Queue<GameplayCommand>();

        private void Start()
        {
            Initialize();
        }

        void Update()
        {
            if(_command == null)
            {
                enabled = false;
                return;
            }

            _command.Execute();
            if(_command.IsDone)
            {
                if(_commandQueue.Count == 0)
                {
                    if(!_loop)
                    {
                        enabled = false;
                    }
                    else
                    {
                        Initialize();
                    }
                }
                else
                {
                    _command = _commandQueue.Dequeue();
                    _command.Prepare();
                }
            }
        }

        private void Initialize()
        {
            foreach (var gameplayCommand in _commands)
            {
                _commandQueue.Enqueue(gameplayCommand);
            }

            if (_commandQueue.Count > 0)
            {
                _command = _commandQueue.Dequeue();
                _command.Prepare();
            }
        }
    }
}