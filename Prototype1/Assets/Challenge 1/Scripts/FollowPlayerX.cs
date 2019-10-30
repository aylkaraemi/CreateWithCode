using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 5);

    // Update is called once per frame
    void Update()
    {
        // repositions camera to stay beside and facing the plane
        transform.position = plane.transform.position + offset;
    }
}
