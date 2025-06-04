using Homework1.Classes.AbstractsClasses;
using Homework1.Classes.SubClasses;





Student Student1 = new Student(4022548844, "Johan", "Lopez", 22, "San Jose", "Estudiante", "Ingenieria", "2024-1260");

Student1.ShowInfo();

var exStudent2 = new ExStudent(
    10101010,
    "María",
    "López",
    22,
    "San José",
    "Estudiante",
    "Ingeniería en Sistemas",
    "B20251337",
    new DateTime(2023, 2, 15)
);

Console.WriteLine();

exStudent2.ShowInfo();




