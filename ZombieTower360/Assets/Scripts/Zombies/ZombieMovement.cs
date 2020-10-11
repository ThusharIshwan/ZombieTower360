using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] private float zombie_speed;

    public float[] bob_force = new float[3];
    public float bob_time_frame;
    private float time_since_last_bob = 0f;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.LookAt(new Vector3(0,3.5f,0));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0f, 0f, zombie_speed * Time.deltaTime);
        Headbob();
    }

    private void Headbob()
    {
        if (time_since_last_bob > bob_time_frame)
        {
            this.transform.LookAt(new Vector3(0, 3.5f, 0));
            this.GetComponentsInChildren<Rigidbody>()[0].AddForce(new Vector3(bob_force[0], bob_force[1], bob_force[2]));
            time_since_last_bob = 0f;
        }
        else
        {
            time_since_last_bob += Time.deltaTime;
        }
    }
}
