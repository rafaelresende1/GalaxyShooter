using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwManager : MonoBehaviour
{

    [SerializeField]
    private GameObject enemyShipPrefab;
    [SerializeField]
    private GameObject[] powerUps;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(enemySpawnRoutine());
        StartCoroutine(PowerupSpawnRoutine());
    }

    // Update is called once per frame
    IEnumerator enemySpawnRoutine()
    {
        while (true)
        {
            Instantiate(enemyShipPrefab, new Vector3(Random.Range(-7f, 7f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
    IEnumerator PowerupSpawnRoutine()
    {
        while (true) {
            int randomPowerup = Random.Range(0, 3);
            Instantiate(powerUps[randomPowerup], new Vector3(Random.Range(-7f, 7f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
     }
}