namespace AulaSete
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Domingo / Sunday";
                    break;
                case 2:
                    day = "Segunda-feira / Monday";
                    break;
                case 3:
                    day = "Terça-feira / Tuesday";
                    break;
                case 4:
                    day = "Quarta-feira / Wednesday";
                    break;
                case 5:
                    day = "Quinta-feira / Thursday";
                    break;
                case 6:
                    day = "Sexta-feira / Friday";
                    break;
                case 7:
                    day = "Sábado / Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine(day);
        }
    }
}