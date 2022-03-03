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
    public float zLimit = 220;
    //The enemy should take damage (maybe receive a little bit of knockback),
    //record this damage change in the console using Debug.Log and the name of the variable you’re using to calculate health.

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
            Destroy(gameObject);
            Debug.Log("Its a hit, enemy health is now" + health);
            if (health <= 0)
            {
                Destroy(Enemy);
            }

        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 75, Color.green);
            if (transform.position.z >= zLimit)
            {
                //destroys projectlie when it hits an enemy or astroid
                Destroy(gameObject);
            }
            //destroys projectlie when it hits an enemy or astroid

        }
        
    }
}

