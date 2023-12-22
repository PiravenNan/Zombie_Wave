using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public GameObject Zombie;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnZombie();
    }
    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnZombie();
            timer = 0;
        }
    }
    void spawnZombie()
    {
        //float lowestPoint = transform.position.y - heightOffset;
        //float highestPoint = transform.position.y + heightOffset;

        Instantiate(Zombie, new Vector3(Random.Range(-50, 50), transform.position.y, Random.Range(-50, 50)), transform.rotation);
    }
}






