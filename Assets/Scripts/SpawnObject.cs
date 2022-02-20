using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject[] animals;

    // Start is called before the first frame update
    void Start()
    {
        float random = Random.Range(0f, 1f);
        if (random < 0.05f)
        {
            int index = Random.Range(0, animals.Length);
            Instantiate(animals[index], transform.position, transform.rotation);
        }
        if (random < 0.5f)
        {
            int index = Random.Range(0, objects.Length);
            Instantiate(objects[index], transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
