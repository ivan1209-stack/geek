using System;
using System.Collections.Generic;
using Data;
using UnityEngine;

namespace DefaultNamespace
{
    public class EnterPoint : MonoBehaviour
    {
        private Initilizions _initilizions;
        private StartInitilization _startinit;
        public LevelProps _p; 

        private void Awake()
        {
            Debug.Log(_p.massiveObjects[0].name);
            _initilizions = new Initilizions();
            _startinit = new StartInitilization(_initilizions);
            _initilizions.Init();
        }
    }
}