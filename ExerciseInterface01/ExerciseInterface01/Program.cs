using ExerciseInterface01.Entities;
using ExerciseInterface01.Services;
using System.Globalization;

Console.WriteLine("Entre com os dados da reserva!");

Console.WriteLine("Qual modelo do carro?");
string name = Console.ReadLine();
Console.WriteLine("Saída (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Chegada (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.WriteLine("Entre com o valor da hora: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com o valor da dia: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(name));
RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("Fatura: ");
Console.WriteLine(carRental.Invoice);