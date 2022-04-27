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
Console.WriteLine();
Console.WriteLine("Lai turpināntu nospiet jebkuru taustiņu");
Console.ReadKey();
Console.Clear();


//________________________________________________________________________________________________________


Console.WriteLine("Lai izveidotu jaunu automašīnu ievadiet tās marku" + "\n");
string brandnameCar = Console.ReadLine();
Car car = new Car(brandnameCar);
Console.WriteLine();

Console.WriteLine("Ievadiet automašinas numurzīmes simbolus");
car.NumberPlace = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Lai turpināntu nospiet jebkuru taustiņu");
Console.ReadKey();
Console.Clear();

//________________________________________________________________________________________________________

Console.WriteLine("Lai izveidotu jaunu produktu ievadiet tās nosaukumu" + "\n");
string produktName = Console.ReadLine();

Console.WriteLine("\n" + "Ievadi produkta platumu centimetros");
double productWidth = double.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Ievadi produkta garumu centimetros");
double productLenght = double.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Ievadi produkta svaru kilogramos");
double productWeight = double.Parse(Console.ReadLine());


Product produkt = new Product(produktName, productWidth, productLenght, productWeight);
Console.WriteLine();

produkt.PrintInfo();

Console.WriteLine();
Console.WriteLine("Lai turpināntu nospiet jebkuru taustiņu");
Console.ReadKey();
Console.Clear();


//________________________________________________________________________________________________________


Console.WriteLine("Ievadiet personas dzimšnas gadu" + "\n");
int yearOfBirth = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet personas dzimšnas mēnesi");
int monthOfBirth = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet personas dzimšnas datumu");
int datebirth = int.Parse(Console.ReadLine());

Person person = new Person(yearOfBirth, monthOfBirth, datebirth);

Console.WriteLine("\n" + "Ievadiet personas vardu");
string name = (Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet personas uzvardu");
string surname = (Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet personas dzimumu");
string sex = (Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet personas hobiju");
string hobby = Console.ReadLine();
Console.WriteLine();
person.Name = name;
person.Surname = surname;
person.Sex = sex;
person.Hobby = hobby;

Console.WriteLine($"Jūsu izveidotai personai ir pilni {person.GetAge()} gadi");
Console.WriteLine();
person.ToGreeting();

Console.ReadLine();


