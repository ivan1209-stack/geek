using Models.MapModels;

namespace DefaultNamespace
{
    public class StartInitilization
    {
        public StartInitilization(Initilizions initilizions)
        {
            var stars = new MassivePropsModel();
            var holes = new MassiveWholesModel();

            initilizions.Add(stars);
            initilizions.Add(holes);
        }
    }
}