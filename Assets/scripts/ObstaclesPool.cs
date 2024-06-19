using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesPool : MonoBehaviour
{
    [SerializeField] private GameObject obstaclesPrefab;
    private GameObject[] obstacles;
    [SerializeField] private int poolSize = 5;
    [SerializeField] private float spawnTime = 2.5f;
    private float timeElapsed;
    private int obstaclesCount;
    [SerializeField] private float xSpawnPosition = 12;
    [SerializeField] private float minYposition = -2;
    [SerializeField] private float maxYposition = 3;
    // Start is called before the first frame update
    void Start()
    {
        obstacles = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i ++)
        {
            obstacles[i] = Instantiate(obstaclesPrefab);
            obstacles[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime && !GameManager.Instance.isGameOver)
        {
            SpawnObstable();
        }

    }

    private void SpawnObstable()
    {
        timeElapsed = 0f;
        float ySpawnPosition = Random.Range(minYposition, maxYposition);
        Vector2 spawPosition = new Vector2(xSpawnPosition,ySpawnPosition);
        obstacles[obstaclesCount].transform.position = spawPosition;
        if(!obstacles[obstaclesCount].activeSelf)
        {
            obstacles[obstaclesCount].SetActive(true);
        }
        obstacles[obstaclesCount].SetActive(true);
        obstaclesCount ++ ;
        if (obstaclesCount == poolSize)
        {
            obstaclesCount = 0 ;
        }
    }
}
