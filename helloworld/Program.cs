using System;
namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Un valor literal es un valor codificado que nunca cambia.
            Console.WriteLine("Hello World!");//string literal
            //Console.WriteLine("The current time is " + DateTime.Now);
            Console.Write("Congrulations!");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code!");
            //El uso de '' para texto, solo es válido para el tipo char. Ej a continuación
            Console.WriteLine(" ");
            Console.WriteLine('b');//char literal
            //Console.WriteLine('error'); -> Genera un error.
            //Imprimir valores numéricos. int literal y decimal literal
            Console.WriteLine(123);
            Console.WriteLine(12.3m); //la m es el sufijo literal o literal suffix que le indica al compilador que deseo trabajar con un valor del tipo decimal
            //Booleanos
            Console.WriteLine(true);
            Console.WriteLine(false);

            //Las variables se definen en camelCase
            string firstName;
            //char userOption;
            decimal temperature;
            int numberOfMessages;
            //short prueba;
            //byte otro;
            //bool processedCustomer;
            firstName = "Bob";
            numberOfMessages = 3;
            temperature = 34.4m;

            Console.Write("Hello, " + firstName + "! You have ");
            Console.Write(numberOfMessages);
            Console.Write(" in your inbox.\tThe temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius\n");
            //otra forma con interpolación
            string message = $"Hello, {firstName}! You have {numberOfMessages} in your inbox. The temperature is {temperature} celsius.\n";
            Console.WriteLine(message);
            //Se pueden declarar variables con var, esto permite tener variables que sean inferidas
            //pero siempre deben ser inicializadas. 
            var varTest = "Hello \"World\"";
            Console.WriteLine(varTest + " Again :v\n");

            Console.WriteLine("C:\\source\\repos"); //Mostrar una ruta de archivos   
            //una forma de evitar usar el \n, \t, etc. Es usando el @ para crear strings literales (Verbatim string literals)
            Console.WriteLine(@"   c:\source\repos\code
             (this is where your code goes)");

            //Se puede hacer uso de caracteres unicode (UTF-16)
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            //Combinación de Verbatim y la interpolación
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotients = 7 / 5;
            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));


            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotients);
            decimal decimalQuotient = 7.0m / 5; //tambien se puede usar 7/5.0m o 7.0m/5.0m
            Console.WriteLine("Decimal quotient: " + decimalQuotient);
            //si los valores a dividir fueran enteros y se desea ver su resultado en decimal se hace lo siguiente
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
            int value = 0;
            value = value + 5;
            value += 5;
            value++;
            value-=2;
            value*=2;    
            value--;        
            Console.WriteLine(value);
            Console.WriteLine(6/10);
        }
    }
}
