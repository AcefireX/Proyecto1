using Proyecto1;



Coche coche = new Coche("jkl564", "Ford", "fiesta");
Secretario secretario = new Secretario("Fede", "Lopez", 45639874, "Valparaiso 3353", 32, 11447788, 40000.0, 12);
Supervisor supervisor = new Supervisor("Mariano", "Martinez", 38636363, "brasil 1234", 45, 1188996633, 60000.0, 50, coche, secretario);
Empleado empleado = new Empleado("Juan", "Perez", 37688688, "san lorenzo 123", 24, 1155555555, 20000.0, 50, supervisor);

Console.WriteLine(empleado.Presentarse());

Console.WriteLine(empleado.mostrarSalario());

empleado.aumentarSalario();

Console.WriteLine(empleado.mostrarSalario());

supervisor.aumentarSalario();  

 Console.WriteLine(supervisor.mostrarSalario());

///Prueba de ramas