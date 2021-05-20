using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieShotCatcher : MonoBehaviour
{
    // Attach a Collider to the required gameObjects.
    // Headshots seem to easy to reward since you are shooting from above, maybe heartshot should be rewarded instead.
    [SerializeField] private bool head;

    private void OnMouseDown()
    {
        SendMessageUpwards("ZombieShot", new object[] { head, 10 });
    }

}
