using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtr : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float roateSpeed;

    [SerializeField] private GameObject bulltetPref;
    [SerializeField] private Transform attackPoint;

    [SerializeField] private float waitAttack = 0.5f;
    [SerializeField] private float timer;
    [SerializeField] private bool canAttack;
    [SerializeField] private bool isAttack;

    public bool canRotate;


    // Update is called once per frame
    void Update()
    {
        this.MoveEnemy();
        this.RotateEnemy();
        if (this.canAttack)
        {
            this.Attack();
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
    }
     void OnTriggerEnter2D(Collider2D other)
    {
    }

    void MoveEnemy()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }

    void Attack()
    {
        timer += Time.deltaTime;
        if (timer > waitAttack)
        {
            isAttack = true;
        }

        if (isAttack)
        {
            isAttack = false;
            timer = 0;
            GameObject bullet = Instantiate(bulltetPref, attackPoint.position, Quaternion.identity);
            Destroy(bullet, 8);
        }
    }

    void RotateEnemy()
    {
        if (canRotate)
        {
            transform.Rotate(new Vector3(0f, 0f, roateSpeed * Time.deltaTime));
        }
    }
}