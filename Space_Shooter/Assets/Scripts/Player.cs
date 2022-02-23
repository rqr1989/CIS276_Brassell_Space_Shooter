using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Player Ship
//Can move in all cardinal directions (up down left right)
//Can fire shots by clicking mouse or pressing space bar that move forward until off screen or colliding with an enemy
//2 different weapon types that can be switched by pressing a button/key (these could be shots with different trajectories, sizes, speeds, different behavior, etc.)
public class Player : MonoBehaviour
{
    private Vector3 moveInput;
    [SerializeField] private Rigidbody rb;

    private PlayerCam playerCam;
   

    [SerializeField] private float speed = 1f;

    [SerializeField] private float jumpForce = 3f;

    private void Awake()
    {
        //sets rb equal to Rigibody
        rb = GetComponent<Rigidbody>();

        playerCam = FindObjectOfType<PlayerCam>();
       

    }
    //works with physics timestep
    private void FixedUpdate()
    {
        //calls MovePlayer method
        MovePlayer();
    }

    private void Update()
    {
        //assign
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce( moveInput * speed * Time.deltaTime);
        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //shoot
          
        }


    }
    private void MovePlayer()
    {
        transform.forward = playerCam.transform.forward;

        Vector3 directionX = transform.right.normalized * moveInput.x;

       Vector3 directionZ = transform.up.normalized * moveInput.z;
    

       rb.velocity = new Vector3(0, rb.velocity.y, 0) + (directionX + directionZ) * speed;

    }

}