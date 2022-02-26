using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapons : MonoBehaviour
{

    // public GameObject Cannon;
    //public Transform cannonShoots;

    public GameObject bullet;
    public GameObject cannonBall;
    public LayerMask mask;
    public GameObject projectile;
    [SerializeField]
    private bool isBullet = true;

    // Update is called once per frame
    void Update()
    {

        //Checks if porjectile hits the enemy using Raycasting
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hitInfo;

        isBullet = !Input.GetKey(KeyCode.E);

        //if space is pressed down
        if (Input.GetButtonDown("Jump"))
        {

            CheckWeapon(isBullet);
            // Launches projectile
            projectile = Instantiate(projectile, transform);

            projectile.GetComponent<Rigidbody>().AddForce(Vector3.forward * 15f, ForceMode.Impulse);

        }
        if (Physics.Raycast(ray, out hitInfo, 75f, mask))
        {
            //draw line form input position to when hit
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);

            //destroys projectlie when it hits an enemy or astroid
            Destroy(projectile);

            
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 75, Color.green);
        }



    }
    void CheckWeapon(bool isBullet)
    {  // Creates projectile that fires from cannon when space is pressed
       //if is Bullet is true
        if (isBullet == true)
        {
            //sets projectile to cannonball
            projectile = bullet;
        }
        //else
        else
        {
            //sets projectile equal to bullet
            projectile = cannonBall;
        }

    }
}


