using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyShip;
    public float rightBoundry = 37.63396f;
    public float leftBoundry = -34.95398f;
    public float topBoundry = 25.55841f;
    public float bottomBoundry = 15f;
    public int Health = 15;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 5f;
    public float lowestSpawnPoint = 5;
    public float spawnTimeLow = 2f;
    public float spawnTimeHigh = 6f;
    public float spawnDelay = 1f;
    int numberOfEnemys;
   
    ///public ;
    // Start is called before the first frame update
    void Awake()
    {
        //sets rb equal to Rigibody
        rb = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        float spawnTime = Random.Range(1,4);
        InvokeRepeating("EnemyShipSpawn", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void EnemyShipSpawn()
    {
       // spawnindex = Random.Range(0, SpawnPoints.Length); objectindex = Random.Range(0, Objetos.Length);

        GameObject enemy;
       
        //creates enemy instance
        enemy = Instantiate(enemyShip);

       
        //spawns enemy within top half of screen
        enemy.transform.position = new Vector3(Random.Range(leftBoundry, rightBoundry), Random.Range(lowestSpawnPoint, topBoundry), 120f);
    

        numberOfEnemys = Random.Range(1, 4);
        //move enemy ship down by 1
        Vector3 movement = new Vector3(0, 1, 0);
        enemy.transform.Translate(movement * speed * Time.deltaTime);

        //checks whether enemy is off screen or has no health left and destroys enemy

        //if ship is below the screen
        if (enemy.transform.position.y <= bottomBoundry)
        {
            //destorys the enemy
            Destroy(enemy);
        }
        //if health is 0 or less destroy enemy
        else if (Health <= 0)
        {
            Destroy(enemy);
        }


    }
 
  
  

}
