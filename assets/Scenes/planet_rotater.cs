using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet_rotater : MonoBehaviour
{
    private Vector3 origin;
    void FixedUpdate()
    {
        transform.RotateAround(origin, Vector3.up, 2f * Time.fixedDeltaTime);
        transform.Rotate(new Vector3(0, 1* Time.fixedDeltaTime, 0));
    }
}
