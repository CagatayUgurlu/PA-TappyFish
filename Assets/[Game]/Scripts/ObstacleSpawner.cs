using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float maxTime;
    float timer;
    public float maxY;
    public float minY;
    float randomY;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            randomY = Random.Range(minY, maxY);
            InstantiateObstacle();
            timer = 0;
        }
    }

    public void InstantiateObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle);
        //newObstacle.transform.position = new Vector2(transform.position.x, (1)transform.position.y);
        newObstacle.transform.position = new Vector2(transform.position.x, randomY);
    }
}
