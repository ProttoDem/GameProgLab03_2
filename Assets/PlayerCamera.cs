using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class PlayerCamera : MonoBehaviour
    {
        public float mouseSensitivity = 100f;

        public Transform playerBody;

        float xRotation = 0f;

        public void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void Update()
        {
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mouseSensitivity;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSensitivity;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
