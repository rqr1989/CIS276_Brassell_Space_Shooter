using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Player Ship
//Can move in all cardinal directions (up down left right)

public class Player : MonoBehaviour
{
    // x coordinate : -13
    public float rightBoundry;

    //x coordinate : -78
    public float leftBoundry;
    //y coordinate : 27
    public float topBoundry;
    // y coordinate: -39
    public float bottomBoundry;

    private Vector3 moveInput;
    [SerializeField] private Rigidbody rb;

    private PlayerCam playerCam;
   

    [SerializeField] private float speed = 5f;
 
   

    private void Awake()
    {
        //sets rb equal to Rigibody
        rb = GetComponent<Rigidbody>();
       

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
   
    }
    private void MovePlayer()
    {
       // transform.forward = player.transform.forward;

        Vector3 directionX = transform.right.normalized * moveInput.x;

       Vector3 directionZ = transform.up.normalized * moveInput.z;

      /**  if (directionX. > rightBoundry)
        {

        }
    **/

       rb.velocity = new Vector3(0, rb.velocity.y, 0) + (directionX + directionZ) * speed * Time.deltaTime;

       // if()

    }

}