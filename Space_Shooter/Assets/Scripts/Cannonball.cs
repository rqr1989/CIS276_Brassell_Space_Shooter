using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    public GameObject Enemy;
    public LayerMask mask;
    public float health = 20;
    public float score = 0;
    [SerializeField] private float speed = 2f;
    //The enemy should take damage (maybe receive a little bit of knockback),
    //record this damage change in the console using Debug.Log and the name of the variable you’re using to calculate health.
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 75f, mask))
        {
            //draw line form input position to when hit
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            health -= 10;
            GetComponent<Rigidbody>().AddForce(Vector3.left * 10f, ForceMode.Impulse);
          


        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 75, Color.green);
        }
        
    }
}

