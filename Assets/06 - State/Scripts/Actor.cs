using UnityEngine;

namespace StateDesignPattern
{
    public class Actor
    {
        public GameObject gameObject;
        public Animator animator;

        public Actor(GameObject gameObject)
        {
            this.gameObject = gameObject;
            this.animator = gameObject.GetComponent<Animator>();
        }

    }
}