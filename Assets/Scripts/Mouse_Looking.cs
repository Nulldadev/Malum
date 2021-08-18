using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mouse_Looking : MonoBehaviour
{//start script


    public float mouseSensitivity = 200f; //duh
    public Transform playerBody; //what will be transformed
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {//start start

       Cursor.lockState = CursorLockMode.Locked; //locks cursor to center of screen

    }//end start


    // Update is called once per frame
    void Update()
    {//start update

      float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //gathers mouse movement in the X axis
      float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;//gathers mouse movement in the Y axis

      xRotation -= mouseY;
      xRotation = Mathf.Clamp(xRotation, -90f, 90f);

      transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
      playerBody.Rotate(Vector3.up * mouseX);
    }//end update


}
