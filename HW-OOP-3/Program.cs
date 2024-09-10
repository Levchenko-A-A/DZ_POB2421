using HW_OOP_3;

Device device = new Device()
{ 
    MaxVolumeDough = 500, 
    MaxVolumeFilling = 100, 
    ConsumptionDough = 50, 
    ConsumptionFilling = 5, 
    CurrentDough = 250, 
    CurrentFilling = 50 
};
device.Print();
device.AddDough(50);
device.AddFilling(25);
device.Print();
device.CountDough(15);
device.CountFilling(15);
device.Print();
device.AllCountDough();
device.AllCountFilling();
