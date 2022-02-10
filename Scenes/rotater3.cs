using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotater3 : MonoBehaviour
{
    private float t;
    void FixedUpdate()
    {
        t += 0.5f;
        Quaternion y = Quaternion.AngleAxis(t, Vector3.up);
        Quaternion z = Quaternion.AngleAxis(40.2f, Vector3.forward);
        Quaternion x = Quaternion.AngleAxis(12f, Vector3.right);
        transform.rotation = y * x * z;
    }
}
