using System;
using System.Security.Cryptography;
Console.WriteLine("������� ����� ��������: ");
Console.WriteLine("1. �������");
Console.WriteLine("2. �������");
Console.WriteLine("3. ��������");
Console.WriteLine("4. ���������");
Console.WriteLine("5. �������� � ������� N ������ �����");
Console.WriteLine("6. ����� ���������� ������ �� �����");
Console.WriteLine("7. ����� 1 ������� �� �����");
Console.WriteLine("8. ����� ��������� �� �����");
Console.WriteLine("9. �����");
Console.WriteLine("������� 1 �����");
double NumOdin = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("������� 2 �����");
double NumDva = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("������� ����� ��������");
double Num = Convert.ToDouble(Console.ReadLine());

while (Num <= 8)

{
    switch (Num)
    {
        case 1:
            Console.Write("�����: ");
            Console.WriteLine(NumOdin + NumDva);
            break;
        case 2:
            Console.Write("�����: ");
            Console.WriteLine(NumOdin - NumDva);
            break;
        case 3:
            Console.Write("�����: ");
            Console.WriteLine(NumOdin * NumDva);
            break;
        case 4:
            Console.Write("�����: ");
            Console.WriteLine(NumOdin / NumDva);
            break;
        case 5:
            Console.Write("�����: ");
            Console.WriteLine(Math.Pow(NumOdin, NumDva));
            break;
        case 6:
            Console.Write("�����: ");
            Console.WriteLine(Math.Sqrt(NumOdin));
            break;
        case 7:
            Console.Write("�����: ");
            Console.WriteLine(NumOdin * 0.01);
            break;
        case 8:
            Console.Write("�����: ");

            int f = 1;
            int i;
            for (i = 2; i <= NumDva; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
            break;
    }
    Console.WriteLine("������� ��������");
    Num = Convert.ToDouble(Console.ReadLine());
}

if (Num > 9) Console.WriteLine("��������, ������ �������� ���� ") ;

