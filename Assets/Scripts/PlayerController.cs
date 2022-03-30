using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] Camera zoomCamera;
    [SerializeField] string playerID;
    [SerializeField] KeyCode zoom;

    private float speed = 20.0f;
    private float turnSpeed = 75.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical" + playerID);
        horizontalInput = Input.GetAxis("Horizontal" + playerID);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(zoom))
        {
            mainCamera.enabled = !mainCamera.enabled;
            zoomCamera.enabled = !zoomCamera.enabled;
        }
    }
}
