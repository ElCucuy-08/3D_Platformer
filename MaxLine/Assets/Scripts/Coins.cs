using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Coins : MonoBehaviour
{
    [SerializeField] Text textCountPaper;//Поле,которое хранит в себе текст с количеством листков на карта
    [SerializeField] int countPaper;//Количество записок на карте

    private void Start()
    {
        countPaper = GameObject.FindGameObjectsWithTag("Golda").Length;//Находим записки с помощью тэга
    }

    private void Update()
    {
        UpdateText();
    }

    void UpdateText()
    {
        textCountPaper.text = "BONUSES:" + countPaper;//выводим текстом,сколько записок осталось на карте
    }

    private void OnTriggerStay(Collider other)//Проверяем,что мы зашли внутрь триггера
    {
        if (other.CompareTag("Golda"))//Проверяем,что это тэг Paper
        {
            { 
                Destroy(other.gameObject);
                countPaper--;
            }
        }
    }
}
