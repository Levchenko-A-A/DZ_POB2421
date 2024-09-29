using HW_OOP_11;

Dispatcher dispatcher = new Dispatcher();

Driver driver1 = new Driver() { Name = "Андрей" };
Driver driver2 = new Driver() { Name = "Валентин" };

Car car1 = new Car() { Model = "Toyota" };
Car car2 = new Car() { Model = "Honda" };

dispatcher.AssignTrip(driver1, car1);
driver1.MakeTripReport();

dispatcher.SuspendDriver(driver2);
driver2.MakeRepairRequest();

car1.CheckCondition();
car2.MakeRepair();
