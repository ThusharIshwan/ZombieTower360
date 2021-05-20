using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingCursorSpot : MonoBehaviour
{
    private int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Debug.Log("Zombie has been shot" + x++);

    }

}
