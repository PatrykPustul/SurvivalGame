using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;
    private float yMinAngle = -30f;
    private float yMaxAngle = 30f;
    // Start is called before the first frame update

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        CameraMovement();
    }

    void CameraMovement()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, yMinAngle, yMaxAngle);
        Vector3 dir = new Vector3(0, 2, -3);
        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0);

        transform.position = Target.position + rotation * dir;
    }

    private void LateUpdate()
    {
      
        transform.LookAt(Target.position);

       Player.rotation = Quaternion.Euler(0, mouseX, 0).normalized;
    }
}
