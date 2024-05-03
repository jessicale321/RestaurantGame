using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{
    [SerializeField] private GameObject foodPrefab;
    [SerializeField] private Transform foodSpawnPoint;

    [SerializeField] private int maxFoodCount = 2;
    private int currentFoodCount = 0;

    private float foodSpawnInterval = 5.0f;
    private float timer = 0f;

    private void Update()
    {
        // TODO: don't want to keep updating timer if max is already met
        timer += Time.deltaTime;
        if (timer >= foodSpawnInterval && currentFoodCount < maxFoodCount)
        {
            Instantiate(foodPrefab, foodSpawnPoint);
            Debug.Log("made pizza");
            currentFoodCount++;
            timer = 0;
        }
    }
}

