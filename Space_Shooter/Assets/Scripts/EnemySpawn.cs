using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public float rightBoundry;
    public float leftBoundry;
    public float topBoundry;
    public float bottomBoundry;
    // Start is called before the first frame update
    void Awake()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
}
