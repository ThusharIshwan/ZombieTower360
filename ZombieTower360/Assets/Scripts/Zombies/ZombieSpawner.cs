using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnZombie();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void SpawnZombie()
    {
        int zomb_dist = Random.Range(250, 400);
        float zomb_angle = Random.Range(0, 2* Mathf.PI);

        float x = zomb_dist * Mathf.Sin(zomb_angle);
        float y = 3.5f;
        float z = zomb_dist * Mathf.Cos(zomb_angle);

        SpawnZombie(new Vector3(x, y, z));
    }

    private void SpawnZombie(Vector3 location)
    {
        Instantiate(zombiePrefab, location, new Quaternion (0,0,0,0));
    }
}
