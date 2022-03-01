using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject enemyShipPrefab;
    public GameObject game_screen_area;
    public int Health = 15;
    //coordinate for top corners of screen
    public double top_left_cornerX = 1;
    public double top_right_cornerX = 648;

    public float speed = 1;
  
    private void Update()
    {
       // while (enemyShipPrefab.transform.position.y > 2.3)
       // {
            //move enemy ship down by 1
            Vector3 movement = new Vector3(0, -1, 0);
            transform.Translate(movement * speed * Time.deltaTime);
        //   }

        //ship doesnt move corectly when this is not commented out
        /**   if (enemyShipPrefab.transform.position.y <= 2.3)
            {
                //destorys the enemy
                Destroy(enemyShipPrefab);

            }
          **/
     
    //attempting to determine corners of screen but not sure they aligh with the canvas corners

        //spawn enemy 
        //Enemies/Obstacles should all spawn near the top of the screen,
        //they should be able to spawn anywhere along the width of the screen(Making sure they are always visible until they move off screen)

        void SpawnEnemy()
        {
            //number of ships that spawn at a time
            int SpawnAmount = Random.Range(1, 3);

            //Range of  seconds between spawns
            float spawnTime = Random.Range(1, 5);

            //Determine Screen Coordinates

            //spawn enemy then move down screen then destroy off screen

            //move enemy ship down by 1
            //Vector3 movement = new Vector3(0, -1, 0);
            //transform.Translate(movement * speed * Time.deltaTime);
           

            // Instantiate(enemyShipPrefab.SpawnAmount, spawnSpot);

        }
   

    }
    //checks whether enemy is off screen or has no health left and destroys enemy
    public void CheckEnemyDestory()

    {
        //if ship is below the screen
       if (enemyShipPrefab.transform.position.y <= 0)
        {
            //destorys the enemy
            Destroy(enemyShipPrefab);
        }
       //if health is 0 or less destroy enemy
       else if (Health <=0)
        {
            Destroy(enemyShipPrefab);
        }
    }

    //  Transform spawnSpot = spawnSpotX, spawnSpotY;
    //    spawnSpot.transform.position.x = spawnSpotX;
    //spawnSpot.transform.position.y = spawnSpotY;
}
