using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDestroy : MonoBehaviour
{


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
        if (other.gameObject.tag.Equals("EnemyTarget"))
        {
            // Health should be lost here.
            //Transform trialtransform = this.gameObject.GetComponent<Transform>().parent.GetComponent<Transform>();
            Destroy(this.gameObject.GetComponent<Transform>().parent.gameObject);
        }
        else if (other.gameObject.tag.Equals("Out of Bounds"))
        {
            Destroy(this.gameObject.GetComponent<Transform>().parent.gameObject);
        }
    }

}
