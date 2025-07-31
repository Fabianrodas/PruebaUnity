using System.Collections;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject[] coinPrefabs;
    public GameObject[] bombPrefabs;

    public float minTime = 1f;
    public float maxTime = 2f;

    void Start()
    {
        StartCoroutine(SpawnCoRoutine());
    }

    IEnumerator SpawnCoRoutine()
    {
        while (true)
        {
            float waitTime = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(waitTime);

            int choice = Random.Range(0, 2);
            GameObject prefabToSpawn = null;

            if (choice == 0)
            {
                if (coinPrefabs.Length > 0)
                {
                    prefabToSpawn = coinPrefabs[Random.Range(0, coinPrefabs.Length)];
                }
            }
            else
            {
                if (bombPrefabs.Length > 0)
                {
                    prefabToSpawn = bombPrefabs[Random.Range(0, bombPrefabs.Length)];
                }
            }

            if (prefabToSpawn != null)
            {
                Instantiate(prefabToSpawn, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            }
        }
    }
}