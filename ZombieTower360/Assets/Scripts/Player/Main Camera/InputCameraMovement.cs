using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCameraMovement : MonoBehaviour
{

    [SerializeField] private float rotation_speed;

    void Update()
    {
        Transform transform = this.GetComponent<Transform>();
        float movement = Input.GetAxis("Horizontal") * rotation_speed * Time.deltaTime;
        transform.Rotate(0.0f, movement, 0.0f, Space.World);
    }
}
