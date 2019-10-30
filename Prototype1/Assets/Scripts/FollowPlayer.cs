using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7); // sets position relative to player object

    // Update is called once per frame
    void Update()
    {
        // repositions camera based on player position, offset above & behind
        transform.position = player.transform.position + offset;
    }
}
