using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player_Pos;
    [SerializeField] float cam_Height;

    private void Update()
    {
        transform.position = new Vector3(player_Pos.position.x, player_Pos.position.y,cam_Height);
    }
}
