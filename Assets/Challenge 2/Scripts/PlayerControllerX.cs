﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawnTime;
    public float spawnCooldown = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
       if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastSpawnTime + spawnCooldown)
        {
            // Spawn the dog and update the last spawn time
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawnTime = Time.time;
        }
    }
}
