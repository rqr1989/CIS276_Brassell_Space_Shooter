using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public GameObject Enemy;
    public LayerMask mask;
    public float health = 5;
    public float score = 0;
    [SerializeField] private float speed = 20f;
    //[SerializeField] private float speed = 6f;
    //The enemy should take damage (maybe receive a little bit of knockback),
    //record this damage change in the console using Debug.Log and the name of the variable you’re using to calculate health.
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 75f, mask))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 10f, ForceMode.Impulse);
            //draw line form input position to when hit
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
         /**   health -= 5;
            if (health >= 1)
            {
                Debug.Log("It's a hit! Enemy health is now " + health);
            }
            else if (health == 0)
            {
                DestroyEnemy();
                score += 5;
                Debug.Log("Score" + score);
            }
         **/

           
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 75, Color.green);
        }
      /**  void DestroyEnemy()
        {
            Destroy(Enemy);
        } **/
    }
}
