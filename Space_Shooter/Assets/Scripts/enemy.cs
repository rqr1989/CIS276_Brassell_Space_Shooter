using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update


   // Random.Range will be your friend for the behavior of these!
//Enemies/Obstacles should all spawn near the top of the screen, they should be able to spawn anywhere along the width of the screen(Making sure they are always visible until they move off screen)
 //The spawning setup will require some creative thinking.A hint would be that you can get x coordinates for the left and right of your screen and the y coordinates for the area you wish for them to be able to spawn in, and use those to decide where to instantiate the position
//Enemies move towards the bottom of the screen, once they are off screen they should be destroyed
//Random Spawn amounts (should be a configurable range of how many enemies can spawn in at the same time)
//Random time in-between spawns(configurable range for how often they can spawn)
}
