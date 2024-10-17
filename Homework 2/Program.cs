class Program
{
    static void Main()
    {
        // 1) Simple arithmetic operations
        int a = 10;
        int b = 5;

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);

        // 2) Precision difference between float, double, and decimal
        float floatValue = 1.0f / 7.0f;
        double doubleValue = 1.0 / 7.0;
        decimal decimalValue = 1.0m / 7.0m;

        Console.WriteLine(floatValue * 7);
        Console.WriteLine(doubleValue * 7);
        Console.WriteLine(decimalValue * 7);

        // 3) Type conversions
        int intValue = 10;
        double doubleValue2 = 10.5;
        float floatValue2 = 5.5f;
        decimal decimalValue2 = 3.3m;

        // Implicit conversions
        double intToDouble = intValue; // int to double
        float doubleToFloat = (float)doubleValue2; // double to float (explicit)
        decimal floatToDecimal = (decimal)floatValue2; // float to decimal (explicit)

        Console.WriteLine(intToDouble);
        Console.WriteLine(doubleToFloat);
        Console.WriteLine(floatToDecimal);

        // 4) Swap values of two variables
        int x = 5;
        int y = 10;
        int temp = x;
        x = y;
        y = temp;

        Console.WriteLine(x);
        Console.WriteLine(y);

        // 5) BMI calculation
        Console.Write("Enter your height in meters: ");
        float height = float.Parse(Console.ReadLine());

        Console.Write("Enter your weight in kilograms: ");
        float weight = float.Parse(Console.ReadLine());

        float bmi = weight / (height * height);
        Console.WriteLine($"Your BMI is: {bmi}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight: Gain some weight.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Normal weight");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obesity");
        }
    }
}