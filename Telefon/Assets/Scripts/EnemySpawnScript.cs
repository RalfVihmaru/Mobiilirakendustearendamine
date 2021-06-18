using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemy;
    int randNr;
    int randX;
    int randY;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randNr = Random.Range(1, 5);
            Vector2 whereToSpawn;
            if (randNr == 1)
            {
                randX = Random.Range(-23, 23);
                randY = 11;
                whereToSpawn = new Vector2(randX, randY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }

            else if (randNr == 2)
            {
                randX = 23;
                randY = Random.Range(-11, 11);
                whereToSpawn = new Vector2(randX, randY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }

            else if (randNr == 3)
            {
                randX = Random.Range(-23, 23);
                randY = -11;
                whereToSpawn = new Vector2(randX, randY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }

            else if (randNr == 4)
            {
                randX = -23;
                randY = Random.Range(-11, 11);
                whereToSpawn = new Vector2(randX, randY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
        }
    }
}
