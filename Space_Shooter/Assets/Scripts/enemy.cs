using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject enemyShipPrefab;
    public GameObject game_screen_area;

    public int enemy_count = 0;
    public int enemy_limit = 25;
    public int ships_per_frame = 1;
  
    //spawn enemies inside game screen
    public float spawn_Radius = 150.0f;

    //float that determines when to delete enemies outside screen
    public float delete_circles_radius = 160.0f;

    public float fast_speed = 25.0f;
    public float slow_speed = 1.0f;

    private void Start()
    {
        
    }
    private void Update()
    {
   
            
    }
/**Vector3 GetRandomPosition()
    {
        Vector3 position = Random.insideUnitCircle.normalized;

        position *= spawn_Radius;

        position += game_screen_area.transform.position;
    }
**/
  
   // Random.Range will be your friend for the behavior of these!
//Enemies/Obstacles should all spawn near the top of the screen,
//they should be able to spawn anywhere along the width of the screen(Making sure they are always visible until they move off screen)
 //The spawning setup will require some creative thinking.A hint would be that you can get x coordinates for the left and right of your screen and the y coordinates
 //for the area you wish for them to be able to spawn in, and use those to decide where to instantiate the position
//Enemies move towards the bottom of the screen, once they are off screen they should be destroyed


//Random Spawn amounts (should be a configurable range of how many enemies can spawn in at the same time)
//Random time in-between spawns(configurable range for how often they can spawn)
}
