double Atriangulo(double a, double b)
{
  return a * b / 2;
}
;

int ACuadrado(int a, int b)
{
  return a * b;
}
;

double ACirculo(double r)
{
  const double PI = Math.PI;
  double rSquared = Math.Pow(r, 2);
  return PI * rSquared;
}
;

void CheckIfYoung(int year)
{
  if (year > 17)
  {
    Console.WriteLine("Mayor edad");
    return;
  }
  ;
  Console.WriteLine("Menor edad");

}
