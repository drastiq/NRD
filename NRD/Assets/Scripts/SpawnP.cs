using UnityEngine;
using System.Collections;
using System;

public class SpawnP : MonoBehaviour {

    public GameObject player;
    public Transform[] spawnPoint;
    public int SpawnPointX = 1;
    public int SpawnPointY = 1;

    // Use this for initialization
    public void spawner()
    { Instantiate(player, spawnPoint[1].position, Quaternion.identity); }

	
   

 

  
}
