﻿namespace S3C_Lab3
{
    internal partial class Program
    {
        class GasoilneCar : Car
        {
            public GasoilneCar()
            {
                has_fuel = false; 
                is_on = false;
            }
            public override void Turn_on()
            {
                if (!is_on)
                {
                    is_on = true;
                    Console.WriteLine("Turning car on...");
                }
                else Console.WriteLine("Engine is already on");
            }
            public override void Turn_off()
            {
                if (is_on)
                {
                    is_on = false;
                    Console.WriteLine("Turning car off...");
                }
                else Console.WriteLine("Engine is already off");
            }
            public override void Drive()
            {
                if (is_on && has_fuel)
                {
                    has_fuel = false;
                    Console.WriteLine("The car is driving...");
                }
                else if (!is_on) Console.WriteLine("The car isn't on");
                else if (!has_fuel) Console.WriteLine("The car isn't fueled with gasoline");
            }
            public override void Fuel()
            {
                if (!has_fuel)
                {
                    has_fuel = true;
                    Console.WriteLine("Tanking car with gasoline...");
                }
                else Console.WriteLine("Car is already fueled with gasoline");
            }
        }
    }
}