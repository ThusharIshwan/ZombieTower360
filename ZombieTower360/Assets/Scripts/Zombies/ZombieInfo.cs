using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieInfo : MonoBehaviour
{
    public int strength = 100;
    public int health = 10;
    public float speed = 3f;
    private bool killable = true;
    private PlayerInfo player;

    private void Start()
    {
        this.gameObject.GetComponent<ZombieMovement>().ChangeSpeed(speed);
        player = this.GetComponentInParent<PlayerInfo>();
    }


    public void ZombieShot(object[] head_shot_gun_damage)
    {
        if (killable)
        {
            Damage((int)head_shot_gun_damage[1]);
        }
        
    }
    public void ZombieToMelee(Vector3 pos)
    {
        killable = false;
        player.DamagePlayer(strength);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("EnemyTarget"))
        {
            ZombieToMelee(this.gameObject.transform.position);
        }
    }

    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(this.gameObject);
    }
}
