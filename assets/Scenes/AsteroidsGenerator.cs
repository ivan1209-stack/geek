using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsGenerator : MonoBehaviour
{
    private Transform tx;
    private GameObject[] asteroids = new GameObject[155];
    public GameObject[] prefabs = new GameObject[2];
    public int asteroidsMax = 100;
    public float asteroidSize = 1;
    public float asteroidDistance = 10;
    public float asteroidClipDistance = 1;
    private float asteroidDistanceSqr;
    private float asteroidClipDistanceSqr;
    private ParticleSystem pSystem;

    private int updateEvery = 1;
    private int counter = 0;

    GameObject root;

    void Start()
    {
        root = new GameObject();
        root.transform.position = Vector3.zero;
        root.name = "Small Asteroid Field";

        tx = transform;
        asteroidDistanceSqr = asteroidDistance * asteroidDistance;
        asteroidClipDistanceSqr = asteroidClipDistance * asteroidClipDistance;
        pSystem = GetComponent<ParticleSystem>();
    }


    private void CreateStars()
    {
        for (int i = 0; i <= asteroidsMax; i++)
        {
            asteroids[i] = Instantiate(prefabs[Random.Range(0, prefabs.Length - 1)]) as GameObject;
            asteroids[i].transform.localScale = Vector3.one * asteroidSize;
            asteroids[i].transform.position = Random.insideUnitSphere * asteroidDistance + tx.position;
            asteroids[i].transform.parent = root.transform;
            //asteroids[i].GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * 2f;
        }

    }

    void Update()
    {
        counter++;
        if (asteroids[0] == null) CreateStars();

        if (counter == updateEvery)
        {
            counter = 0;

            for (int i = 0; i < asteroidsMax; i++)
            {
                if ((asteroids[i].transform.position - tx.position).sqrMagnitude > asteroidDistanceSqr)
                {
                    asteroids[i].transform.position = Random.insideUnitSphere.normalized * asteroidDistance + tx.position;
                    //asteroids[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                }

            }
        }

    }
}
