using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damaged : MonoBehaviour
{
    private List<GameObject> details;
    [SerializeField] private GameObject damagedObject;
    [SerializeField] private Material dm;
    private Material[] da = new Material[5];
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            da[i] = dm;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ApplyChildren_GetComponents(transform.gameObject, damagedObject);
    }
    void ApplyChildren_GetComponents(GameObject parent, GameObject parent2)
    {
        foreach (Transform child in parent.GetComponentsInChildren<Transform>())
        {
            foreach (Transform child2 in parent2.GetComponentsInChildren<Transform>())
            {
                if (child.name == child2.name && child.tag == "dship")
                {
                    child2.gameObject.TryGetComponent<MeshRenderer>(out MeshRenderer r);
                    if (r != null)
                    {
                        r.materials = da;
                    }
                }
            }
            
        }
    }
}
