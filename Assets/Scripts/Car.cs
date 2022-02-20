using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speedMin = 1f;
    public float speedMax = 2f;
    public bool isSpawnedRight;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(speedMin, speedMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // car
        if (collision.gameObject.layer == LayerMask.NameToLayer("Car"))
        {
            speed = collision.gameObject.GetComponent<Car>().speed;
            speed += 0.1f;
        }
        // player
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // game over
        }
    }
}
