using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float spawnTime;
    [SerializeField] private GameObject carPrefab;
    [SerializeField] private List<GameObject> spawnPoints;
    void Start()
    {
        StartCoroutine(SpawnVehicle());
    }

    
    private IEnumerator SpawnVehicle()
    {
        int spawnPosition = Random.Range(0, 2);
        Instantiate(carPrefab, spawnPoints[spawnPosition].transform.position, Quaternion.Euler(0, 180, 0));
        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(SpawnVehicle());
    }
}
