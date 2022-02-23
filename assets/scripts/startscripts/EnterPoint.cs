using System;
using System.Collections.Generic;
using Data;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class EnterPoint : MonoBehaviour
    {
        private Initilizions _initilizions;
        private StartInitilization _startinit;
        [SerializeField] private LevelProps props; 
        [SerializeField] private Material skybox; 

        private void Awake()
        {
            RenderSettings.skybox = skybox;
            _initilizions = new Initilizions();
            _startinit = new StartInitilization(_initilizions);
            _initilizions.Init();
        }
    }
}