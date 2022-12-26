avia[] flight = new avia[5];
for (int i = 0; i < flight.Length; i++)
{
    Console.Write("Номер Авиарейса:");
    int num = int.Parse(Console.ReadLine());
    Console.Write("Введите время вылета:");
    TimeOnly timestart = TimeOnly.Parse(Console.ReadLine());
    Console.Write("Введите время прилета:");
    TimeOnly timeend = TimeOnly.Parse(Console.ReadLine());
    Console.WriteLine("Направление:");
    string country = Console.ReadLine();
    Console.WriteLine("Марка самолета:");
    string brand = Console.ReadLine();
    Console.WriteLine("Расстояние:");
    int distance = int.Parse(Console.ReadLine());
    avia[i] = new avia(num, timestart, timeend, country, brand, distance);
}
for (int i = 0; i < flight.Length; i++)
{
    if ((DateTime.Now.Year - flight[i].dataContract.Year) < 1 &&
        (DateTime.Now.Month - flight[i].dataContract.Month) > 0)
        flight[i].Print();
}
struct avia
{
    public string SurName;
    public string Post;
    public DateOnly dataContract;
    public int PeriodOfMonth;
    public int Oklad;

    public avia(string surName, string post, DateOnly dataContract, int periodOfMonth, int oklad)
    {
        SurName = surName;
        Post = post;
        this.dataContract = dataContract;
        PeriodOfMonth = periodOfMonth;
        Oklad = oklad;
    }
    public void Print()
    {
        Console.WriteLine($"Фамилия:{SurName}, должность:{Post}," +
            $"Дата подписания контракта:{dataContract}," +
            $" Срок действия контракта:{PeriodOfMonth}," +
            $" Оклад:{Oklad}");
    }