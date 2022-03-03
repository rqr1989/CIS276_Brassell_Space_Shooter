using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject enemyShipPrefab;

    public int Health = 15;


    public float speed = 1;
  
    private void Update()
    {
      
            //move enemy ship down by 1
            Vector3 movement = new Vector3(0, -1, 0);
            transform.Translate(movement * speed * Time.deltaTime);

        void SpawnEnemy()
        {
            
           

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

  
}
