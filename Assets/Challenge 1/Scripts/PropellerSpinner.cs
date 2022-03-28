using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinner : MonoBehaviour
{
    private Vector3 spinSpeed = new Vector3(0, 0, 90);

    void Update()
    {
        transform.Rotate(spinSpeed);
    }
}
