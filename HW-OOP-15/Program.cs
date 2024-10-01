
using HW_OOP_15;
List<Building> buildings = new List<Building>();
Building building = new Building("Жилой дом 1", 115, 38, 500, "Мегаполис");
buildings.Add(building);
building = new Building("Жилой дом 2", 30, 10, 250, "Поселок");
buildings.Add(building);
building = new Building("Жилой дом 3", 70, 17, 450, "Город");
buildings.Add(building);
Building.Volume(buildings);




