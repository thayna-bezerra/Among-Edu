using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxForLevel : MonoBehaviour
{
    public float speed;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(translation: Vector3.right * speed * Time.deltaTime);

        if(transform.position.x > 45.4f)
        {
            transform.position = startPosition;
        }
    }
}