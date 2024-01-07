using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject collectiblePrefab;
    [SerializeField] private List<float> spawnCoordinates;
    [SerializeField] private float collectibleSpawnChance;
    [SerializeField] private float startSpawnRate = 2;
    [SerializeField] private float endSpawnRate = 0.2f;
    [FormerlySerializedAs("timer")] [SerializeField] private UIController uiController;

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            //Lerp spawn rate base on timer progress
            float spawnRate = Mathf.Lerp(startSpawnRate, endSpawnRate, uiController.GetNormalizedProgress());
            yield return new WaitForSeconds(spawnRate);
            
            //Determine random Position
            var random = Random.Range(0, spawnCoordinates.Count);
            var randomCoordinate = spawnCoordinates[random];
            
            //Determine Enemy or Collectible
            var chance = Random.Range(0f, 100f);
            bool shouldSpawnCollectible = chance < collectibleSpawnChance;
            GameObject toSpawn = shouldSpawnCollectible ? collectiblePrefab : enemyPrefab;
            
            //Spawn and Inject
            var spawned = Instantiate(toSpawn, new Vector3(randomCoordinate, 8f, -20f), quaternion.identity);
            var movement = spawned.GetComponent<Movement>();
            movement.Initialize(uiController);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }
    
}
