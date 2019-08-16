using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private float spawnTime = 1.5f;
    

    private void Start()
    {
        StartCoroutine(CometSpawnRoutine());
    }

    private void SpawnComet()
    {
        GameObject comet = Instantiate(prefab);
        
    }

    
    private IEnumerator CometSpawnRoutine()
    {
        while (true)
        {
            SpawnComet();
            yield return new WaitForSeconds(spawnTime);
        }

    }

}
