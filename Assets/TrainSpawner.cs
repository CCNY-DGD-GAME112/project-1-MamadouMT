using UnityEngine;

public class TrainSpawner : MonoBehaviour
{
    public GameObject trainPrefab;
    public float spawnDelay = 3f;

    void Start()
    {
        InvokeRepeating("SpawnTrain", 1f, spawnDelay);
    }

    void SpawnTrain()
    {
        int side = Random.Range(0, 2);

        if (side == 0)
        {
            GameObject train = Instantiate(trainPrefab, new Vector3(-10, 0, 0), Quaternion.identity);
            train.GetComponent<TrainAttack>().SetDirection(1);
        }
        else
        {
            GameObject train = Instantiate(trainPrefab, new Vector3(10, 0, 0), Quaternion.identity);
            train.GetComponent<TrainAttack>().SetDirection(-1);
        }
    }
}
