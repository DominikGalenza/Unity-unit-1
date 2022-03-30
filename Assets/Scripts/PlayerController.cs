using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] Camera zoomCamera;

    private float speed = 20.0f;
    private float turnSpeed = 75.0f;
    private float horizontalInput;
    private float forwardInput;
    private KeyCode zoom = KeyCode.Z;

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(zoom))
        {
            mainCamera.enabled = !mainCamera.enabled;
            zoomCamera.enabled = !zoomCamera.enabled;
        }
    }
}
