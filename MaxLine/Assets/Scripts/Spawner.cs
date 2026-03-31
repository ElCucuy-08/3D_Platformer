using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // Ссылка на префаб
    public Vector3 spawnPosition = new Vector3(0, 0, 0); // Позиция

    void Start()
    {
        // Создание копии
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }

}
