using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t+= 0.1f;
        Quaternion y = Quaternion.AngleAxis(t, Vector3.up);
        Quaternion z = Quaternion.AngleAxis(-12f, Vector3.forward);
        Quaternion x = Quaternion.AngleAxis(21f, Vector3.right);
        transform.rotation = y * x * z;
    }
}
