using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater2 : MonoBehaviour
{

    private float t;
    void FixedUpdate()
    {
        t += 0.05f;
        Quaternion z = Quaternion.AngleAxis(t, Vector3.forward);
        transform.rotation = z;
    }
}
