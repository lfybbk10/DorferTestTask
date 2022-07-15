using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class LevelSpawner : MonoBehaviour, ISpawner
    {
        public Vector3 spawnPosition { get; set; }
        
        [SerializeField] private GameObject levelPrefab;

        [SerializeField] private float yOffsetBetweenLevels;

        public void Spawn()
        {
            Instantiate(levelPrefab, spawnPosition, Quaternion.identity);
        }

        public void SetSpawnPosition(Vector3 levelSpawnTriggerPosition)
        {
            spawnPosition = new Vector3(levelSpawnTriggerPosition.x, levelSpawnTriggerPosition.y - yOffsetBetweenLevels,
                levelSpawnTriggerPosition.z);
        }
    }
}