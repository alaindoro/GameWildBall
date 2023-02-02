using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Imputs
{
    [RequireComponent(typeof(Rigidbody))]

    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody _playerRigitbody;

        [SerializeField, Range(0, 10)] private float _speed;

        private void Awake()
        {
            _playerRigitbody = GetComponent<Rigidbody>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void MoveCharacter(Vector3 movement)
        {
            _playerRigitbody.AddForce(movement * _speed);
        }

#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            _speed = 2;
        }
#endif
    }
}

