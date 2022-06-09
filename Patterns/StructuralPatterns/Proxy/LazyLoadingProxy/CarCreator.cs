namespace StructuralPatterns.Proxy.LazyLoadingProxy
{
    internal class CarCreator : ICarCreator
    {
        private readonly string _carName;
        public CarCreator(string carName)
        {
            _carName = carName;
        }
        public Car CreateCar()
        {
            Console.WriteLine("--> Car Created");
            return new Car(_carName);
        }
    }
}
