using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCollisionTest : MonoBehaviour
{

    public GameObject test_collide_area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == test_collide_area)
        {
            Debug.Log("winner");
        }
        else
        {
            Debug.Log("loser");
        }
    }
}
