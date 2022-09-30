using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxForLevel : MonoBehaviour
{
    private float length;
    private float StartPos;

    public float ParallaxEffect;

    void Start()
    {
        StartPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float RePos = transform.position.x * (1 - ParallaxEffect);
        float Distance = transform.position.x * ParallaxEffect;

        transform.position = new Vector3(StartPos + Distance, transform.position.y, transform.position.z);

        if (RePos > StartPos + length)
        {
            StartPos += length;
        }

        else if (RePos < StartPos - length)
        {
            StartPos -= length;
        }
    }
}