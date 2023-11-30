namespace S3C_Lab3
{
    internal partial class Program
    {
        abstract class Car
        {
            public abstract void Turn_on();
            public abstract void Turn_off();
            public abstract void Drive();
            public abstract void Fuel();

            public bool has_fuel;
            public bool is_on;
        }
    }
}