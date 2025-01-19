/* Patrón Builder:
///  Es un patrón de diseño creacional que nos permite construir objetos complejos
/// paso a paso.
///
///  El patrón nos permite producir distintos tipos y representaciones
///  de un objeto empleando el mismo código de construcción.
///
///  Es útil cuando necesitamos construir un objeto complejo con muchas partes
///  y queremos que el proceso de construcción sea independiente de las partes
///  que lo componen.
///
/// https://refactoring.guru/es/design-patterns/builder  */


using PatronBuilder;

Computer basicComputer = new ComputerBuilder()
    .SetCpu("Inter core 2 Duo")
    .SetRam("4GB")
    .SetStorage("256GB")
    .Build();

basicComputer.DisplayConfiguration();

Computer gamingComputer = new ComputerBuilder()
    .SetCpu("Inter core i9")
    .SetRam("32GB")
    .SetStorage("1TB")
    .SetGpu("Nvidia RTX 3090")
    .Build();

gamingComputer.DisplayConfiguration();

Computer serverComputer = new ComputerBuilder()
    .SetCpu("Inter Xeon")
    .SetRam("128GB")
    .SetStorage("4TB")
    .SetGpu("Nvidia Tesla V100")
    .Build();

serverComputer.DisplayConfiguration();

var usersQuery = new QueryBuilder("users")
    .Select("id", "name", "email")
    .Where("age > 18")
    .Where("country = 'Cri'")
    .OrderBy("name", "ASC")
    .Limit(10)
    .Execute();

Console.WriteLine(usersQuery);