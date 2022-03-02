using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Player Ship
//Can move in all cardinal directions (up down left right)

public class Player : MonoBehaviour
{

    public float rightBoundry;
    public float leftBoundry;
    public float topBoundry;
    public float bottomBoundry;
    private Vector3 moveInput;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 5f;
 
   

    private void Awake()
    {
        //sets rb equal to Rigibody
        rb = GetComponent<Rigidbody>();
        Camera cam = FindObjectOfType<Camera>();
        //Get coordinates for bottom left corner of screen
        Vector3 bottomLeft = cam.ViewportToWorldPoint(new Vector3(0.2f, 0.2f, transform.position.z));
       //Get coordinates for top right coner of screen
        Vector3 topRight = cam.ViewportToWorldPoint(new Vector3(0.8f, 0.8f, transform.position.z));
        //assign bottomleft's x coordinate to leftBoundry
        leftBoundry = bottomLeft.x;

        //assign topright's x coordinate to rightBoundry
        rightBoundry = topRight.x;

        //Assign topRight's y coordinate to topBoundry
        topBoundry = topRight.y;
        //Assign bottomLeft's y coordinate to bottomBoundry
        bottomBoundry = bottomLeft.y;

        //make sure player starts at center of screen
        transform.position = new Vector3(((leftBoundry + rightBoundry) / 2), (topBoundry + bottomBoundry) / 2, transform.position.z);

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


        Vector3 directionX;
        Vector3 directionZ;
        directionX = transform.right.normalized * moveInput.x;
        directionZ = transform.up.normalized * moveInput.z;
        rb.velocity =  (directionX + directionZ) * speed * Time.deltaTime;

            //Make Sure Ship Stays Within the boundries
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftBoundry, rightBoundry),
            Mathf.Clamp(transform.position.y, bottomBoundry, topBoundry), transform.position.z);

    }

}