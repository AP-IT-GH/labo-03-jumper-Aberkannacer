using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public static ObstacleSpawner Instance;

    public GameObject obstaclePrefab;
    public GameObject bonusObstaclePrefab;

    public Transform spawnPoint;
    public GameObject currentObstacle;

    void Awake()
    {
        Instance = this;
    }

    public void SpawnObstacle()
    {
        if (currentObstacle != null)
            Destroy(currentObstacle);

        GameObject prefab = Random.value > 0.5f ? obstaclePrefab : bonusObstaclePrefab;
        currentObstacle = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
