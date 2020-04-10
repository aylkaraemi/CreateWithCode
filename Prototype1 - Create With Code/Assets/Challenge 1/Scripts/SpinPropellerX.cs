using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private Vector3 rotation = new Vector3(0, 0, 30);
    
    // Update is called once per frame
    void Update()
    {
        // rotates propeller around its z axis
        transform.Rotate(rotation, Space.Self);
    }
}
