using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 3.0f;
    public float maxX = 7.0f; // These are the positions the 
    public float minX = -7.0f; // objects moves between.

    private int _direction = 1; // Which direction is the object currently moving in?

    private void Update()
    {
        transform.Translate(_direction * speed * Time.deltaTime, 0, 0);

        bool bounced = false;
        if (transform.position.x > maxX || transform.position.x < minX)
        {
            _direction = -_direction; // Toggle the direction back and forth.
            bounced = true;
        }
        if (bounced) // Make an extra movement this frame if the object swithed directions.
        {
            transform.Translate(_direction * speed * Time.deltaTime, 0, 0);
        }
    }
}
