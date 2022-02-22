using Data;
using Interfaces;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

namespace Models.MapModels
{
    public class MassiveWholesModel : MonoBehaviour, IModel
    {
        [FormerlySerializedAs("_props")] [SerializeField]
        private LevelProps props;
        private GameObject _model;


        
        public void Initilize(int index, Vector3 scale, [CanBeNull]Vector3 position)
        {
            _model = Instantiate(props.massiveObjects[index], position, Quaternion.identity); 
            _model.transform.localScale = scale;
            _model.transform.position = position;
        } 
        
        public Vector3 Appeal(Vector3 newPosition)
        { 
            _model.transform.position = newPosition; 
            return _model.transform.position;
        } 
        
        public GameObject GetGameobject()
        {
            return _model;
        }

        public int CountObject()
        {
            return props.massiveObjectsWholes.Count;
        }
    }
}