using CollectionsPart;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("29901011234567".IsValidEgyptianNationalId()); // True
        System.Console.WriteLine("19901011234567".IsValidEgyptianNationalId()); // False
        System.Console.WriteLine("2990101123456".IsValidEgyptianNationalId()); // False

        System.Console.WriteLine("01012345678".IsValidEgyptianPhoneNumber()); // True
        System.Console.WriteLine("+201512345678".IsValidEgyptianPhoneNumber()); // True
        System.Console.WriteLine("01312345678".IsValidEgyptianPhoneNumber()); // False
        System.Console.WriteLine("0101234567".IsValidEgyptianPhoneNumber()); // False
        System.Console.WriteLine("0101234567a".IsValidEgyptianPhoneNumber()); // False

    }
}
