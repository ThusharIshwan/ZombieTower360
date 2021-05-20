using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;

    public void Start()
    {
        SpawnZombie();
    }

    public IEnumerator Wave()
    {
        for (int i = 0; i < 300; i++)
        {
            SpawnZombie();

            yield return new WaitForSeconds(1f);
        }
        yield return null;
    }

    
    private void SpawnZombie()
    {
        int zomb_dist = Random.Range(50, 100);
        float zomb_angle = Random.Range(0, 2* Mathf.PI);

        float x = zomb_dist * Mathf.Sin(zomb_angle);
        float y = 0f;
        float z = zomb_dist * Mathf.Cos(zomb_angle);

        SpawnZombie(new Vector3(x, y, z));
    }

    private void SpawnZombie(Vector3 location)
    {
        Instantiate(zombiePrefab, location, new Quaternion (0,0,0,1), this.transform);
    }
}
