namespace StructuralPatterns.Proxy.LazyLoadingProxy
{
    internal class CarCreatorOnDemand : ICarCreator
    {
        private readonly string _name;
        private readonly bool _needLogging;
        public CarCreatorOnDemand(string carName, bool needLogging = false)
        {
            _name = carName;
            _needLogging = needLogging;
        }

        public Car CreateCar()
        {
            CarCreator carCreator;
            Car car = default;
            if (_needLogging)
            {
                var logger = new Logger();
                logger.Log($"Creating car with name {_name}", () =>
                {
                    car = new CarCreator(_name).CreateCar();
                });
            }
            else
            {
                car = new CarCreator(_name).CreateCar();
            }

            return car;
        }
    }
}
