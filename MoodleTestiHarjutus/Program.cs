//Mis hinne?

Console.WriteLine("Mis hinde sa said?");

char hinne = Convert.ToChar(Console.ReadLine().ToLower());


if (hinne == 'a')
{
    Console.WriteLine("Suurepärane!");
}
else if(hinne == 'b')
{
    Console.WriteLine("Väga hea!");
}
else if (hinne == 'c')
{
    Console.WriteLine("Hea!");
}
else if (hinne == 'd')
{
    Console.WriteLine("Rahuldav!");
}
else if (hinne == 'e')
{
    Console.WriteLine("Kasin!");
}
else if (hinne == 'f')
{
    Console.WriteLine("Puudulik!");
}
else
{
    Console.WriteLine("Vale väärtus!");
}
//switch (hinne)
//{
//   case 'a':
//       Console.WriteLine("Suurepärane!");
//       break;
//   case 'b':
//       Console.WriteLine("Väga hea!");
//       break;
//   case 'c':
//      Console.WriteLine("Hea!");
//      break;
//   case 'd':
//     Console.WriteLine("Rahuldav!");
//       break;
//   case 'e':
//       Console.WriteLine("Kasin!");
//       break;
//   case 'f':
//       Console.WriteLine("Puudulik!");
//       break;
//
//    default:
//        Console.WriteLine("Vale väärtus!");
//        break;
//}
