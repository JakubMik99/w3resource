namespace Zadania
{
    public class DataTypes
    {
        //1. Write a C# Sharp program that takes three letters as input and display them in reverse order.
        public string Zad1(params char[] letter) => string.Join(' ', letter.Reverse());
        //2. Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. 
        public void Zad2(int number, int width)
        {
            int widthCopy= width;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < widthCopy; j++)
                {
                    Console.Write(number);
                }
                widthCopy--;
                Console.WriteLine();
            }
        }
        //3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
        public void Zad3()
        {
            string userID, password, loginId,loginPass;
            int counter=0;
            bool passed=false;
            Console.Write("User id: ");
            userID= Console.ReadLine();
            Console.Write("Password: ");
            password= Console.ReadLine();
            do
            {
            Console.Write($"User id: {userID}");
            Console.Write($"Password: {password}");

            Console.Write("User id: ");
            loginId= Console.ReadLine();
            Console.Write("Password: ");
            loginPass= Console.ReadLine();
            if (loginId==userID && password==loginPass)
                passed=true;
            else
                counter++;
                
            } while (counter<3 && !passed);
            if (passed)
                Console.WriteLine($"login sucessful");
            else
                Console.WriteLine($"out of attempts");
        }
        //Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.
        public string Zad4(int firstVal, int secondVal, char symbol)
        {
            string fullOperation;
            int outcome;
            switch (symbol)
            {
                case '+':
                outcome = firstVal+secondVal;
                break;
                case '-':
                outcome = firstVal-secondVal;
                break;
                case '*':
                outcome = firstVal*secondVal;
                break;
                case '/':
                outcome = firstVal/secondVal;
                break;
                default:
                outcome = int.MinValue;
                break;
            }
            if (outcome==int.MinValue)
                fullOperation = "Wrong symbol";
            else
                fullOperation = $"{firstVal}{symbol}{secondVal}={outcome}";
            return fullOperation;
        }
        //5. Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
        public float Zad5(float r,out float per) 
        {
            per = (float)Math.PI*2*r;
            //area
            return (float)(Math.PI*Math.Pow(r,2));
        }
        //6. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5).
        public void Zad6()
        {
            for (int i = -5; i < 6; i++)
                Console.WriteLine($"{Zad6Func(i)}={i}^2+2{i}+1");
        }
        public int Zad6Func(int y)=> (int)Math.Pow(y,2)+2*y+1;
        //7. Write a C# Sharp program that takes distance and time as input and displays the speed in kilometres per hour and miles per hour
        public void Zad7(float distance, float hours, float minutes)
        {
            Console.WriteLine($"Speed in meters/sec: {distance/(((hours*60)+minutes)*60)}");
            Console.WriteLine($"Speed in km/h: {(distance/1000)/(hours+(minutes/60))}");
            Console.WriteLine($"Speed in miles/h: {(distance*0.000621371192)/(hours+(minutes/60))}");
            
        }
        //8. Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
        public void Zad8(float sphereRadius)
        {
            Console.WriteLine($"Surface= {4*Math.PI*Math.Pow(sphereRadius,2)}");
            Console.WriteLine($"Volume= {4/3*Math.PI*Math.Pow(sphereRadius,3)}");
        }
        //9. Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.
        public string Zad9(char symbol)
        {
            if (symbol>='0' && symbol <='9')
                return "its a digit";
            else if (symbol=='a'|| symbol=='e' ||symbol=='i' ||symbol=='o' ||symbol=='u' ||symbol=='y')
                return "its a vowel";
            else
                return "its other symbol";

        }
        //10. Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
        public bool Zad10(int firstVal, int secondVal) => firstVal%2==0 && secondVal%2==0 || firstVal%2!=0 && secondVal%2!=0;
        //11. Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
        public string Zad11(int dec) => Convert.ToString(dec,2);
        //12. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        public string Zad12(int rollNumber, string studentName, int physics, int chemistry, int computerApp)
        {
            int totalMarks = physics+chemistry+computerApp;
            float per = totalMarks/3;
            string div = per>=60? "First" : (per<60 && per>=48? "second" : (per<48&&per>=36 ? "pass" : "fail"));
            string outcome = $"Roll no: {rollNumber}\nName of student: {studentName}\n" +
                             $"Physics: {physics}\nChemistry: {chemistry}\n ComputerApplication {computerApp}\n" +
                             $"Total: {totalMarks} \nPercentage: {per}\n Division: {div}";
            return outcome;
        }
        //13. Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below : Go to the editor
        // Temp < 0 then Freezing weather
        // Temp 0-10 then Very Cold weather
        // Temp 10-20 then Cold weather
        // Temp 20-30 then Normal in Temp
        // Temp 30-40 then Its Hot
        // Temp >=40 then Its Very Hot 
        public string Zad13(int temp)
        {
            string tempState= string.Empty;
            switch (temp)
            {
                case <0:
                tempState = "Its freezing";
                break;
                case >=0 and <10:
                tempState = "Its its very cold";
                break;
                case >=10 and <20:
                tempState = "Its cold";
                break;      
                case >=20 and <30:
                tempState = "Its normal temp";
                break;
                case >=30 and <40:
                tempState = "Its hot";
                break;     
                case >=40:
                tempState = "Its very hot";
                break;
                default:
            }
            return tempState;
        }




























    }
}