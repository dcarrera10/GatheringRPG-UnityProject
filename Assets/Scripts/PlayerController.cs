using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        // Start is called before the first frame update

        public Camera cam;
        public float movementSpeed = 15f;
        public float rotationSpeed;

        void Start()
        {
            cam = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            playerMovement();
            //playerRotation();
        }

        void playerMovement()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            ///float rotationInput = transform.rotation.y;

            /// tried to fix the rotation issue:
            ///if (rotationInput == -180)
            ///{
            ///    verticalInput = -verticalInput;
            ///}
            ///else if (rotationInput == 0)
            ///{
            ///    verticalInput = -verticalInput;
            ///}

            Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);
            direction.Normalize();
            transform.Translate(direction * movementSpeed * Time.deltaTime);

            //attempt rotation:
            /*if (direction != Vector3.zero)
            {
                Quaternion toRotate = Quaternion.LookRotation(direction, Vector3.up);

                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
            }*/

        }

        void playerRotation()
        {

        }
    }
}