using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour
{
    public GameObject balloonPrefab;

    float spawnDelay = 0.5f;
    float velocity = 64f;

    Rigidbody2D rb;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        SpawnBalloon();
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(Spawn());
        yield return null;
    }

    void SpawnBalloon()
    {
        Vector2 spawnPosition = new Vector2(Screen.width * Random.Range(0.1f, 0.9f), -200f);
        GameObject obj = Instantiate(balloonPrefab, spawnPosition, transform.rotation, transform);
        rb = obj.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f, velocity);
        velocity *= 1.001f;
        spawnDelay *= 0.999f;
    }
}
