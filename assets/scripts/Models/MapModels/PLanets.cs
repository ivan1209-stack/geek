using Data;
using Interfaces;
using UnityEngine;

namespace Models.MapModels
{
    public class PLanets : MonoBehaviour, IModel
    {
        [SerializeField] private LevelProps _props;
        private GameObject _model;


        public void Initilize(int index, Vector3 scale, Vector3 position)
        {
            _model = Object.Instantiate(_props.planets[index]); 
            _model.transform.localScale = scale;
            _model.transform.position = position;
        }
        
        public Vector3 Appeal(Vector3 newPosition)
        { 
            _model.transform.position = newPosition; 
            return _model.transform.position;
        }
        public int CountObject()
        {
            return _props.planets.Count;
        }
    }
}