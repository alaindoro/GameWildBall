using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Imputs
{
    [RequireComponent(typeof(PlayerMovement))]

    public class PlayerInput : MonoBehaviour
    {
        private Vector3 _movement;
        private PlayerMovement _playerMovement;
        private Vector3 _jump;
        private float jump;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        void Start()
        {


        }

        void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVar.HorizontalAxis);
            float vertical = Input.GetAxis(GlobalStringVar.VerticallAxis);
            bool isJump = Input.GetButtonDown(GlobalStringVar.JumpButton);

            if (isJump)
            {
                if (jump < 40)
                {
                    jump += 20;
                }
                else
                {
                    jump = 40;
                }
            }
            else
            {
                if (jump > 0)
                {
                    jump -= 5;
                }
                else
                {
                    jump = 0;
                }
            }

            _movement = new Vector3(-horizontal, 0, -vertical).normalized;
            _jump = new Vector3(0, jump, 0);
        }

        private void FixedUpdate()
        {
            _playerMovement.MoveCharacter(_movement);
            _playerMovement.MoveCharacter(_jump);
        }
    }
}

