using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public float mouse_Sensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //to hide the cursor
        Cursor.lockState = CursorLockMode.Locked;        
    }

    // Update is called once per frame
    void Update()
    {
        // Capture the player input
        float mouseX = Input.GetAxis("Mouse X") * mouse_Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouse_Sensitivity * Time.deltaTime;

        // Calculation of the player movements
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f); // Sets a limit so the camera dont flip

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
        
    }
}
