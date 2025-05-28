// See https://aka.ms/new-console-template for more information
Console.WriteLine("******Bai_1******");
Console.WriteLine("Hello, World!");
string name = "Huyma";
double salary = 203.2313;
string mssv = "SE";
string str1= string.Format("name{0,6}, mssv{1,3}, salary{2,8:N2}", name, mssv, salary);
Console.WriteLine(str1);

Console.WriteLine("*****Bai_2******");
Console.WriteLine("Enter name: ");
string Name = Console.ReadLine();
Console.WriteLine("Name is: " + Name);

Console.WriteLine("******Bai_3******");
(string MyString, int MyNumber) MyValues = ("Hello World!", 2025);
Console.WriteLine("MyString: " + MyValues.MyString);
Console.WriteLine("MyNumber: " + MyValues.MyNumber);
Console.ReadLine();

Console.WriteLine("******Bai_4******");
int x = 5;
Console.WriteLine(x > 2 ?"Hello" : "No Hello");

Console.WriteLine("******Bai_5******");
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);

Console.WriteLine("******Bai_6******");
int b = 50 + 150;
Console.WriteLine(b);

Console.WriteLine("******Bai_7******");
int c = 5;
Console.WriteLine(c>3 && c<10);

Console.WriteLine("******Bai_8******");
/* Max, Min, Sqrt, Abs, Round*/
Console.WriteLine(Math.Max(5,10));

Console.WriteLine("******Bai_9******");
string txt = "asnwjakfbw";
Console.WriteLine("The length of the txt string is: " + txt.Length);

Console.WriteLine("******Bai_10******");
string name2 = "Hello World!";
Console.WriteLine(name2.ToUpper());
Console.WriteLine(name2.ToLower());
