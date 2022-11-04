using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float hInput, vInput;
    float mouseX, mouseY, movementSpeed;

    [SerializeField]
    GameObject cameraPoint, cameraX, cameraY;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        transform.Translate(Vector3.forward * vInput * movementSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * hInput * movementSpeed * Time.deltaTime);

        cameraPoint.transform.position = transform.position;

        if(Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.up * mouseX * 200 * Time.deltaTime);
            cameraX.transform.Rotate(Vector3.up * mouseX * 200 * Time.deltaTime);
            cameraY.transform.Rotate(Vector3.left * mouseY * 200 * Time.deltaTime);
        }    
    }
}
