using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCameraMovement : MonoBehaviour
{

    [SerializeField] private float rotation_speed;

    private float y_rot = 0f;
    public float camera_y = 17.39f;
    public float set_space = 0.6f;

    void Update()
    {
        Transform transform = this.GetComponent<Transform>();
        float movement = Input.GetAxis("Horizontal") * rotation_speed * Time.deltaTime;
        if (movement != 0.0f)
        {
            transform.Rotate(0.0f, movement, 0.0f, Space.World);
            y_rot += movement;
            if (y_rot > 180) { y_rot -= 360; }
            else if (y_rot < -180) { y_rot += 360; }

            transform.position = (new Vector3(Mathf.Sin(y_rot * Mathf.PI / 90) * set_space, camera_y, Mathf.Cos(y_rot * Mathf.PI / 90) * set_space));
        }
        transform.Rotate(0.0f, movement, 0.0f, Space.World);
    }
}
