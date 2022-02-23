using System;
using Data;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Models.MapModels
{
    public class Asteroids : MonoBehaviour, IModel
    {
        [FormerlySerializedAs("_props")] [SerializeField] public LevelProps props;
        private GameObject _model;


        public void Initilize(Vector3 scale, Vector3 position)
        {
            _model = Object.Instantiate(props.asteroids[(int)Random.Range(0, props.asteroids.Count-1)]); 
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
            return props.asteroids.Count;
        }
    }
}