using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomspawner : MonoBehaviour
{
    public TextMeshProUGUI waveCountText;
    int waveCount = 1;
    public float spawnRate = 1.0f;
    public float timeBetweenWaves = 3.0f;

    public int enemyCount;
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    bool waveIsDone = true;

    // Start is called before the first frame update
   void Update()
    {
        waveCountText.text = "Wave: " + waveCount.ToString();

        if (waveIsDone == true)
        {
            StartCoroutine(waveSpawner());
        }
    }
  
    // Update is called once per frame
    IEnumerator waveSpawner()
    {
        waveIsDone = false;

        for (int i = 0; i < enemyCount; i++)
        {
            int randEnemy = Random.Range(0,  enemyPrefabs.Length);
            int randSpawPoint = Random.Range(0,  spawnPoints.Length);

            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawPoint].position, transform.rotation);
            
            yield return new WaitForSeconds(spawnRate);
        }

        spawnRate -= 0.1f;
        enemyCount += 3;
        waveCount += 1;

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;
    }



}