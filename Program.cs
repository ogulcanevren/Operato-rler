// See https://aka.ms/new-console-template for more information
int x = 3;
int y = 3;
y = y+2;
Console.WriteLine(y);

y += 2;
Console.WriteLine(y);

y/=1;
Console.WriteLine(y);

x *=2;
Console.WriteLine(x);

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted)
Console.WriteLine("Fevkaladenin Fevkinde");

if(isSuccess || isCompleted)
Console.WriteLine("Eh işte");

if(isSuccess && !isCompleted)
Console.WriteLine("İdare eder");

if(!isSuccess && isCompleted)
Console.WriteLine("Bu da idare eder");

int a = 3;
int b = 4;

bool sonuc = a<b;
Console.WriteLine(sonuc);

sonuc = a>b;
Console.WriteLine(sonuc);

sonuc = a>=b;
Console.WriteLine(sonuc);

sonuc = a<=b;
Console.WriteLine(sonuc);

sonuc = a==b;
Console.WriteLine(sonuc);

sonuc = a!=b;
Console.WriteLine(sonuc);

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1/sayi2;
Console.WriteLine(sonuc1);

int sonuc2 = sayi1+sayi2;
Console.WriteLine(sonuc2);

int sonuc3 = sayi1*sayi2;
Console.WriteLine(sonuc3);

int sonuc4 = ++sayi1;
Console.WriteLine(sonuc4);

int sonuc5 = sonuc3%3;
Console.WriteLine(sonuc5);