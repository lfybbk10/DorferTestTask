using UnityEngine;

public interface ISpawner
{
    Vector3 spawnPosition { get;}

    void Spawn();

    void SetSpawnPosition(Vector3 position);
}
