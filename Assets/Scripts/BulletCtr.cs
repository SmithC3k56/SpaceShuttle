using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtr : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private bool isEnemy = false;
    void Start()
    {
        Invoke("DestroyObj",5);
    }

    
    void Update()
    {
        Move();
    }
    
     void OnTriggerEnter2D(Collider2D other)
    {
        if (isEnemy)
        {
            
        }
    }
    void Move()
    {
        if (isEnemy)
        {
            
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
