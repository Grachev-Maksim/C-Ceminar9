// задача 40 - HARD необязательная.
//  На вход программы подаются три целых положительных числа.
//   Определить , является ли это сторонами треугольника.
//    Если да, то вывести всю информацию по нему - площадь, 
//    периметр, значения углов треугольника в градусах, 
//    является ли он прямоугольным, равнобедренным, 
//    равносторонним.

Console.WriteLine("Введите сторону А");
double a =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону Б");
double b =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону С");
double c=Convert.ToDouble(Console.ReadLine());
bool flag = checktriag(a,b,c);
if (flag)
{Console.WriteLine($"ТРеугольник с сторонами {a},{b},{c} существует");
Console.WriteLine($" Периметр треугольника с сторонами {a},{b},{c} равен {perimetr(a,b,c)}");
Console.WriteLine($" Площадь  треугольника с сторонами {a},{b},{c} равен {square(a,b,c)}");
double [] ang = angle (a ,  b , c) ;
Console.WriteLine($" углы   треугольника с сторонами {a},{b},{c} равены {ang[0]} , {ang[1]} , {ang[2]}");
CheckProp(a,b,c,ang);
}
else Console.WriteLine($"ТРеугольник с сторонами {a},{b},{c} не существует");

bool checktriag(double a, double b ,double c )
{
 bool flag = false;
 if (a<b+c&& b<a+c&&c<a+b) flag=true ;
 return flag ;   
}

double perimetr (double a , double b , double c)
{
    double p =a+b+c ;
    return p ;

}
double square (double a , double b , double c)
{
    double p =perimetr(a,b,c)/2;
double s =Math.Sqrt(p*(p-a)*(p-b)*(p-c));
return s ;
}
double[] angle (double a , double b , double c)
{
    double al = Math.Acos((b*b+c*c-a*a)/(2*b*c));
    double bl = Math.Acos((a*a+c*c-b*b)/(2*a*c)) ;
    double cl = Math.Acos((a*a+b*b-c*c)/(2*b*a));
    double [] ang = new double[3];
    ang[0] = al*180/Math.PI;
    ang[1]= bl*180/Math.PI;
    ang [2] = cl*180/Math.PI;
return ang ;
}

void CheckProp(double a,double b, double c,double[] ang)
{
 string temp="";
 if (a==b && a==c)
 temp=" равносторонний";
 else if (a==b||a==c||b==c)
 temp=" равнобедренный";
 if (ang[0]==90||ang[1]==90||ang[2]==90)
 temp=temp+" прямоугольный";
 if (temp!="") Console.WriteLine($"Треугольник {temp}");
}