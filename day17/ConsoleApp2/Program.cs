using System;
using HomeApplianceLibrary;

class Program
{
    static void Main()
    {
        
        WashingMachine washingMachine = new WashingMachine("Samsung", 7);

        washingMachine.DisplayStatus();
        washingMachine.StartWash();
        washingMachine.DisplayStatus();
        washingMachine.StopWash();
        washingMachine.DisplayStatus();
    }
}