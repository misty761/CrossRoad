using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    // direction
    public bool isRight = true;
    // spawn
    public float spawnIntervalMin = 1f;
    public float spawnIntervalMax = 2f;
    float spawnInterval;
    float spawntime;
    public GameObject[] prefCars;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
        spawntime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        spawntime += Time.deltaTime;
        if (spawntime > spawnInterval)
        {
            spawntime = 0f;
            spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
            int random = Random.Range(0, prefCars.Length);
            Car car = Instantiate(prefCars[random], transform.position, Quaternion.Euler(Vector3.zero)).GetComponent<Car>();
            car.isSpawnedRight = isRight;
            if (isRight)
            {
                // spawn car
                car.transform.rotation = Quaternion.Euler(Vector3.zero);
            }
            else
            {
                // spawn car
                car.transform.rotation =  Quaternion.Euler(0, 180, 0);
            }
        }
    }
}
