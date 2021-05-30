using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateDesignPattern
{
    public class State
    {
        public virtual void Enter(Actor owner)
        {

        }

        public virtual State Update(Actor owner)
        {
            return this;
        }

        public virtual void Exit(Actor owner)
        {

        }
    }
}