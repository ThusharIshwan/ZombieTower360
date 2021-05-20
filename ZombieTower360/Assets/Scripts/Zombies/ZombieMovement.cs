using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    private float zombie_speed = 0;
    [SerializeField] private Animator ZombieAnimmator;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.LookAt(new Vector3(0,1f,0));

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0f, 0f, zombie_speed * Time.deltaTime);
    }

    public void ChangeSpeed(float new_speed)
    {
        zombie_speed = new_speed;
        ZombieAnimmator.SetFloat("MoveSpeed", zombie_speed);
    }
}
