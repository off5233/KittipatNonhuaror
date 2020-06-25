using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float gravity;
    public Rigidbody player;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {

        player.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, player.velocity.y, Input.GetAxis("Vertical") * speed);


    }
}
