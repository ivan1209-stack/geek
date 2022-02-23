using Models.MapModels;
using UnityEngine;

namespace DefaultNamespace
{
    public class StartInitilization
    {
        public StartInitilization(Initilizions initilizions)
        {
            GameObject gameObject = new GameObject();
            var stars = gameObject.AddComponent<MassivePropsModel>();
            var holes = gameObject.AddComponent<MassiveWholesModel>();

            initilizions.Add(stars);
            initilizions.Add(holes);
        }
    }
}