using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{
    [SerializeField] private GameObject pizzaPrefab;
    [SerializeField] private Transform pizzaSpawnPoint;

    [SerializeField] private int maxPizzaCount = 2;
    private int currentPizzaCount = 0;

    private float pizzaSpawnInterval = 5.0f;
    private float timer = 0f;

    private void Update()
    {
        // TODO: don't want to keep updating timer if max is already met
        timer += Time.deltaTime;
        if (timer >= pizzaSpawnInterval && currentPizzaCount < maxPizzaCount)
        {
            Instantiate(pizzaPrefab, pizzaSpawnPoint);
            Debug.Log("made pizza");
            currentPizzaCount++;
            timer = 0;
        }
    }
}

