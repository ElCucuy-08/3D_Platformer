using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public GameObject itemPrefab; // Ссылка на префаб в инспекторе
    IEnumerator SpawnRoutine()
    {
        while (true)
        { // Бесконечный цикл
            SpawnItem();
            yield return new WaitForSeconds(2.0f); // Пауза в 2 секунды
        }
    }

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }
    void SpawnItem()
    {
        Vector3 randomPos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
    }
}
