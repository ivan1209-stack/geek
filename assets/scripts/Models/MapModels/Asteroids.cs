using System;
using Data;
using Interfaces;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Models.MapModels
{
    public class Asteroids : MonoBehaviour, IModel
    {
        [SerializeField] private LevelProps _props;
        private GameObject _model;


        public void Initilize(int index, Vector3 scale, Vector3 position)
        {
            _model = Object.Instantiate(_props.asteroids [index]); 
            _model.transform.localScale = scale;
            _model.transform.position = position;
        }
        
        public Transform Appeal(Vector3 newPosition, Quaternion newRotation)
        { 
            _model.transform.position = newPosition;
            _model.transform.rotation = newRotation;
            return _model.transform;
        }
        public int CountObject()
        {
            return _props.asteroids.Count;
        }
    }
}