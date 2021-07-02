using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public int MouseSensitivity;
    public Transform playerBody;
    private UIPosition uiPosition;
    public float xRotate = 0f;

    void Start()
    {
        uiPosition = this.gameObject.GetComponentInParent<UIPosition>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(uiPosition.inventoryActive == false)
        {
            float MouseX = Input.GetAxis("Mouse X");
            float MouseY = Input.GetAxis("Mouse Y");

            xRotate -= MouseY * 2;
            xRotate = Mathf.Clamp(xRotate, -60f, 60f);

            transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);

            playerBody.Rotate(Vector3.up * MouseX * 2);
        }

    }
}
