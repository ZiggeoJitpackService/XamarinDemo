namespace Ziggeo.Xamarin.NetStandard.Demo.Utils
{
    public class ControllerStyleModel
    {
        public ControllerStyleModel(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; set; }
        public string Name { get; set; }
    }
}