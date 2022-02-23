using System.Collections.Generic;
using Interfaces;
using Unity.VisualScripting;
using UnityEngine;


namespace DefaultNamespace
{
    public sealed class Initilizions
    {
        public readonly List<IModel> _InitializeModels;

        internal Initilizions()
        {
            _InitializeModels = new List<IModel>();
        }

        public Initilizions Add(IModel model)
        {
            _InitializeModels.Add(model);
            return this;
        }

        public void Init()
        {
            for (int i = 0; i < _InitializeModels.Count; i++)
            {
                _InitializeModels[i].Initilize(Vector3.one, Vector3.zero);
            }
        }
    }
}