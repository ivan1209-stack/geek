using System.Collections.Generic;
using Interfaces;
using Unity.VisualScripting;
using UnityEngine;


namespace DefaultNamespace
{
    public sealed class Initilizions
    {
        public readonly List<IModel> _InitializeControllers;

        internal Initilizions()
        {
            _InitializeControllers = new List<IModel>();
        }

        public Initilizions Add(IModel model)
        {
            _InitializeControllers.Add(model);
            return this;
        }

        public void Init()
        {
            for (int i = 0; i < _InitializeControllers.Count; i++)
            {
                _InitializeControllers[i].Initilize(0 , Vector3.one, Vector3.zero);
            }
        }
    }
}