using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWawes = 10f;   
    public float timeBetweenSpawns = .5f;
    public int maxEnemyCount = 5;
    public TextMeshProUGUI countDownText;
    private float countdown = 5f;
    private int enemyCount = 0;  
    public static List<Transform> enemys = new List<Transform>();

    private void Start()
    {
        NewWave();
    }

    private void Update()
    {
        if(enemys.Count == 0 && enemyCount == maxEnemyCount)
        {
            NewWave();
            enemyCount = 0;      
        }
    }

    private void NewWave()
    {
        StartCoroutine(openingCountdown());
    }

    private void SpawnWave()
    {
        StartCoroutine(SpawnMobCoroutine());
    }

    private IEnumerator openingCountdown()
    {
        for (int i = (int)countdown; i >= 0; i--)
        {
            yield return new WaitForSeconds(1);
            countDownText.text = i.ToString();
        }
        countDownText.text = "";
        SpawnWave();
    }

    private IEnumerator SpawnMobCoroutine()
    {
        for (int i = 0; i < maxEnemyCount; i++)
        {
            SpawnMob();
            enemyCount++;
            yield return new WaitForSeconds(timeBetweenSpawns);           
        }       
    }

    private void SpawnMob()
    {
        Vector3 spawnSpot = new Vector3(-70, 2, -65);
        Transform newMob = Instantiate(enemyPrefab, spawnSpot, Quaternion.Euler(enemyPrefab.eulerAngles));
        enemys.Add(newMob);
    }
}
