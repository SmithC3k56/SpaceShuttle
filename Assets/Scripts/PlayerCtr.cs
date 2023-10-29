using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtr : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float maxY, minY;

    [SerializeField] private GameObject bulltetPref;
    [SerializeField] private Transform attackPoint;

    [SerializeField] private float waitAttack=0.36f;
    [SerializeField] private float timer;
    [SerializeField] private bool canAttack;

    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        this._audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Attack();

    }
    void MovePlayer()
    {
        float v = Input.GetAxis("Vertical");

        if (v > 0)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            if (temp.y > maxY)
            {
                temp.y = maxY;
            }
            transform.position = temp;
        }
        else if (v<0)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            if (temp.y < minY)
            {
                temp.y = minY;
            }
            transform.position = temp;
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision!");
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered!");
           
        
    }
    void Attack()
    {
        timer += Time.deltaTime;
        if (timer > waitAttack)
        {
            canAttack = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canAttack)
            {
                this._audioSource.Play();
                canAttack = false;
                timer = 0;
                GameObject bullet =  Instantiate(bulltetPref,attackPoint.position,Quaternion.identity);
                 Destroy(bullet,9);
            }
        }
    }
}
