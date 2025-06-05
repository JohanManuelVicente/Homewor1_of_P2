using Homework1.Classes.AbstractsClasses;
using Homework1.Classes.SubClasses;
using System.ComponentModel.DataAnnotations;


var Student1 = new Student(4022548844, 
    "Johan", "Lopez", 22, "San Jose", "Estudiante", "Ingenieria", "2024-1260"
    );

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

var Employee1 = new Employees(

    4022165454,
    "Carlos",
    "Tavares",
    30,
    "Jacobo",
    "Empleado",
    30000,
    "Docente",
    "Desarrollo de Software"
    );

var Teaching1 = new Teaching(
    4022165454,
    "Carlos",
    "Tavares",
    30,
    "Jacobo",
    "Empleado",
    30000,
    "Docente",
    "Desarrollo de Software",
    "Master",
    14,
    "Programacion 1"
    );

var Teacher1 = new Teacher(
    4022165454,
    "Jose",
    "Linares",
    30,
    "Jacobo",
    "Empleado",
    40000,
    "Maestro",
    "Desarrollo de Software",
    "Master",
    14,
    "Programacion 1",
    "Tiempo completo",
    "Excelencia de software"

    );

var Administrative1 = new Administrative(
    "Centro de Software",
    "8AM - 4PM",
    "SI",
    04022165454,
    "Eugenio",
    "De Jesus",
    30,
    "Jacobo",
    "Empleado",
    60000,
    "Docente",
    "Desarrollo de Software"

    );

var Adnmin1 = new Administrators(
     4022165454,
    "Ruth",
    "Gonzalez",
    45,
    "D.N.",
    "Empleado",
    70000,
    "Administrador",
    "Desarrollo de Software",
    "PhD",
    34,
    "Programacion paralela",
    "Gestionar docentes",
    25

    );



Student1.ShowInfo();

Console.WriteLine();

exStudent2.ShowInfo();

Console.WriteLine();

Employee1.ShowInfo();

Console.WriteLine();

Teaching1.ShowInfo();

Console.WriteLine();

Administrative1.ShowInfo();

Console.WriteLine();

Teacher1.ShowInfo();

Console.WriteLine();

Adnmin1.ShowInfo();


