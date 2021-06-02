using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//lets the camera follow the player
public class camera_control : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        transform.position = new Vector3(
            player.position.x,
            player.position.y,
            -10);
    }
}
