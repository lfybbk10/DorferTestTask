using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class BallChangeLevelTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag.Equals("SpawnTrigger"))
        {
            print("123123");
            LevelSpawner levelSpawner = GameObject.FindObjectOfType<LevelSpawner>();
            levelSpawner.SetSpawnPosition(other.transform.position);
            levelSpawner.Spawn();
        }
    }
}
