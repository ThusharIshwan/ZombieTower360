using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    private int playerhealth = 100;

    public void DamagePlayer(int damage)
    {
        playerhealth -= damage;
        if (playerhealth <= 0)
        {
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        Debug.Log("YOU DIED");
    }
}
