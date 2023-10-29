using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject shuttleEnemy;
    [SerializeField] private GameObject asteroidEnemy;

    [SerializeField] private float minHeight, maxHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createNewShuttleEnemy()
    {
        var newShuttle = Instantiate(this.shuttleEnemy);
        newShuttle.transform.position = new Vector3(
            newShuttle.transform.position.x,
            Random.Range(minHeight, maxHeight),
            newShuttle.transform.position.z);

    }

    void createNewAsteroyEnemy()
    {
        var newAsteroy = Instantiate(this.asteroidEnemy);
        
        newAsteroy.transform.position = new Vector3(
            newAsteroy.transform.position.x,
            Random.Range(minHeight, maxHeight),
            newAsteroy.transform.position.z);
    }
    
}
