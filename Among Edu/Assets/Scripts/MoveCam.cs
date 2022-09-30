using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public float speed;

    public GameObject point1, point2;
    private Vector2 nextPos;

    void Update()
    {
        if (transform.position == point1.transform.position)
        {
            nextPos = point2.transform.position;
        }

        if (transform.position == point2.transform.position)
        {
            nextPos = point1.transform.position;
        }

        transform.position = Vector2.MoveTowards(transform.position, nextPos, speed);

    }
}
