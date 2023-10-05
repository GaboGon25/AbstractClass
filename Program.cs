using PracticaProgra;

EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado("Pablo Hernandez", 25000);
EmpleadoPorHora empleadoPorHora = new EmpleadoPorHora("Modesto Cruz", 50, 60);

Console.WriteLine($"El salario de {empleadoAsalariado.Nombre} es : C${empleadoAsalariado.CalcularSalario()}  Cordobas netos");
Console.WriteLine($"El salario de {empleadoPorHora.Nombre} es : C${empleadoPorHora.CalcularSalario()}  Cordobas Netos");