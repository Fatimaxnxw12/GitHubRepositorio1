//programa que permita visualizar los departamentos de nicaragua con
//cantidad poblacional
//Encuentra el Mayor, menor, sumar y ordenar los datos
using Departamentos;
// Lista de departamentos
List<Depto> lstDeptos = new List<Depto>()
{
    new Depto("Boaco", 185013),
    new Depto("Carazo", 197139),
    new Depto("Chinandega", 439906),
    new Depto("Chontales", 190863),
    new Depto("Costa Caribe Norte", 530586),
    new Depto("Costa Caribe Sur", 414543),
    new Depto("Esteli", 229866),
    new Depto("Granada", 214317),
    new Depto("Jinotega", 475630),
    new Depto("León", 421050),
    new Depto("Madriz", 174744),
    new Depto("Managua", 1546939),
    new Depto("Masaya", 391903),
    new Depto("Matagalpa", 593503),
    new Depto("Nueva Segovia", 271581),
    new Depto("Río San Juan", 135446),
    new Depto("Rivas", 182645)
};
// Encontrar el mayor y el menor (población)
Depto minDepto = lstDeptos.OrderBy(d => d.population).First();
Depto maxDepto = lstDeptos.OrderBy(d => d.population).Last();
// Ordenar los departamentos
var DeptOrdenado = lstDeptos.OrderBy(d => d.population);
// Mostrar departamentos ordenados
foreach (var item in DeptOrdenado)
    Console.WriteLine($"{item.Name,-20}==>{item.population,10:N0}");
// Mostrar el mayor y el menor
Console.WriteLine($"Dpto con menor población: {minDepto.Name}");
Console.WriteLine($"Dpto con mayor población: {maxDepto.Name}");
// Sumar todas las poblaciones con SUM de LINQ
int total = lstDeptos.Select(d => d.population).Sum();
Console.WriteLine($"Población General: {total:N0}");

