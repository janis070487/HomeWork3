using Class;
Console.WriteLine("Lai izveidotu jautu telefonu ievadiet viņa brendu nosaukumu" + "\n");
string brandname = Console.ReadLine();
Phone phone = new Phone(brandname);

Console.WriteLine($"{"\n"}Ievadiet telefona modeļa nosaukumu");
phone.Model = Console.ReadLine();

Console.WriteLine($"{"\n"}Ievadiet telefona platumu");
phone.Width = double.Parse(Console.ReadLine());

Console.WriteLine($"{"\n"}Ievadiet telefona garumu");
phone.Lenght = double.Parse(Console.ReadLine());

Console.WriteLine($"{"\n"}ievadiet lelefona augstumu");
phone.Height = double.Parse(Console.ReadLine());

Console.WriteLine();
phone.GetInfo();

Console.WriteLine($"{"\n"}Ievadiet ziņu lai nosūtītu");
string mesage = Console.ReadLine();
Console.WriteLine($"{"\n"}Ievadiet adresāta numuru");
string number = Console.ReadLine();
Console.WriteLine();
phone.SendSms(number, mesage);