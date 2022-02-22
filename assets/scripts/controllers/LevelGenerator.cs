
using System;
using System.Collections.Generic;
using Models.MapModels;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = System.Random;

namespace controllers
{
    public class LevelGenerator
    {
        private MassivePropsModel modelS = new MassivePropsModel();
        private MassiveWholesModel modelW = new MassiveWholesModel();
        private Queue<Transform> _queueRoot = new Queue<Transform>();
        
        public void CenterGenerator(int CountStars, int CountHoles, float _radius, List<GameObject> ObjectInstantiate)
        {
            if (CountStars + CountHoles > 3) throw new Exception("You try create more then 3 stars or black holes in center");
            if (CountHoles + CountStars == 1)
            {
                Object.Instantiate(ObjectInstantiate[0], Vector3.zero, Quaternion.identity);
            }
            else if (CountHoles + CountStars == 2)
            {
                if (ObjectInstantiate.Count != 0)
                {
                    GameObject root = new GameObject("Root");
                    _queueRoot.Enqueue(root.transform);
                    for (int i = 0; i < CountHoles + CountStars; i++)
                    {
                        float angle = i * Mathf.PI * 1 / CountHoles + CountStars;
                        Vector2 pos = new Vector3(Mathf.Cos(angle), 0,
                            Mathf.Sin(angle)) * _radius;

                        GameObject temp = Object.Instantiate(ObjectInstantiate[i], pos,
                            Quaternion.identity);
                    }
                }
            }
            else
            {
                if (ObjectInstantiate.Count != 0)
                {
                    GameObject root = new GameObject("Root");
                    _queueRoot.Enqueue(root.transform);
                    for (int i = 0; i < CountHoles + CountStars; i++)
                    {
                        float angle = i * Mathf.PI * 1 / CountHoles + CountStars;
                        Vector2 pos = new Vector3(Mathf.Cos(angle), 0,
                            Mathf.Sin(angle)) * _radius;
                        
                        GameObject temp = Object.Instantiate(ObjectInstantiate[i], pos,
                            Quaternion.identity);
                    } 
                }
            }
        }

        
    }
}