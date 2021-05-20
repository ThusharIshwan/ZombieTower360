using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDestroy : MonoBehaviour
{

    public PlayerInfo player;

    public void ZombieShot(bool headshot)
    {
        Destroy(this.gameObject);
    }
    public void ZombieToMelee(Vector3 pos)
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag.Equals("EnemyTarget"))
        {
            ZombieToMelee(this.gameObject.transform.position);
            player.DamagePlayer(100);
        }
    }

}
