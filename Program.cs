var rand = new Random();

bool  val01 = true;
sbyte val02 = (sbyte)rand.Next(-128, 127);
short val03 = (short)rand.Next(-32768, 32767);
int val04 = rand.Next(-2147483648, 2147483647);
long val05 = rand.Next();
byte val06 = (byte)rand.Next(0, 255);
ushort val07 = (ushort)rand.Next(0, 65535);
uint val08 = (uint)rand.Next(0, 429496729);
ulong val09 = (ulong)rand.Next();
float val10 = (float)rand.NextDouble();
double val11 = rand.NextDouble();
char val12 = (char)rand.Next(47, 122);
decimal val13 = (decimal)rand.NextDouble();
string val14 = "";

// генерация рандомной строки
for (int i = 0; i < rand.Next(5, 15); i++) 
{
    val14 = val14 + (char)rand.Next(47, 122);
}

// функция для упрощенного вывода
void printTypes(int size, Type type, string c) 
{
    string a = size.ToString();
    string b = type.ToString();
    Console.WriteLine($"Size : {a}\tType : {b}\t Value : {c}");
}
// вывод 
printTypes(sizeof(bool),    typeof(bool),   val01.ToString());
printTypes(sizeof(sbyte),   typeof(sbyte),  val02.ToString());
printTypes(sizeof(short),   typeof(short),  val03.ToString());
printTypes(sizeof(int),     typeof(int),    val04.ToString());
printTypes(sizeof(long),    typeof(long),   val05.ToString());
printTypes(sizeof(byte),    typeof(byte),   val06.ToString());
printTypes(sizeof(ushort),  typeof(ushort), val07.ToString());
printTypes(sizeof(uint),    typeof(uint),   val08.ToString());
printTypes(sizeof(ulong),   typeof(ulong),  val09.ToString());
printTypes(sizeof(float),   typeof(float),  val10.ToString());
printTypes(sizeof(double),  typeof(double), val11.ToString());
printTypes(sizeof(char),    typeof(char),   val12.ToString());
printTypes(sizeof(decimal), typeof(decimal),val13.ToString());
printTypes(val14.Length * sizeof(char),    typeof(string), val14);