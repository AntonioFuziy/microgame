﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehaviour_Pell : MonoBehaviour
{
    private Vector3 direction;
    private float speed = 10.0f;
    void Start()
    {
        direction = new Vector3(1, 0).normalized;
    }

    void Update()
    {
        if (GameData.lost)
        {
            Destroy(gameObject);
            return;
        }
        transform.position += direction * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy")) return;
        Destroy(gameObject);
    }

    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
}
