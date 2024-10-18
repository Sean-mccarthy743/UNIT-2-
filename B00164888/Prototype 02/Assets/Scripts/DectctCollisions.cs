using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Boundaries for the object on the z-axis
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can go here, but it's not needed for this script
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

