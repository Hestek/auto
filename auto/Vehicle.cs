using System;
using System.Collections.Generic;
using System.Text;

namespace auto
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Brand { get; }
        public string Fuel { get; set; }
        public double EngineVolume { get; set; }
        public int FuelLevel { get; set; }
        public int Distance { get; set; }
        public double PneuState { get; set; }
        

        public Vehicle(string brand)
        {
            Type = "Unknown";
            Brand = brand;
            Fuel = "Gas";
            EngineVolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;
        }
        public void Move()
        {
            EngineVolume -= 0.4;
            FuelLevel -= 1;
            if (FuelLevel < 0)
            {
                FuelLevel = 0;
                
            }
            Distance += 10;
            PneuState -= 0.1;
        }
        public void Refuel()
        {
            FuelLevel = 100;
        }
        
        public void TireChange()
        {
            PneuState = 100;
        }
        public void DistanceReset()
        {
            Distance = 0;
        }
        public void EngineRepair()
        {
            EngineVolume = 1000;
        }
    }
}
