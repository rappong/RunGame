using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformspawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public int count = 3;

    public float timeBetSpawnMin = 1.25f;
    public float timeBetSpawnMax = 2.25f;
    private float timeBetspawn;

    public float ymin = -3.5f;
    public float yMax = 1.5f;
    private float xPos = 20f;

    private GameObject[] platforms;
    private int currentIndex = 0;

    private Vector2 poolPosition = new Vector2(0, -25);
    private float lastspawnTime;

    void Start()
    {
     platforms = new GameObject[count];
        for(int i = 0; i < count; i++)
        {
            platforms[i] = Instantiate(platformPrefab, poolPosition, Quaternion.identity);
        }
        lastspawnTime = 0f;
        timeBetspawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameover)
        {
            return;
        }
        if(Time.time >= lastspawnTime + timeBetspawn)
        {
            lastspawnTime = Time.time;

            timeBetspawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);
            float yPos = Random.Range(ymin, yMax);
            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);

            platforms[currentIndex].transform.position = new Vector2(xPos, yPos);
            currentIndex++;

            if(currentIndex >= count)
            {
                currentIndex = 0;
            }
        }
    }
}
