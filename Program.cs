// PARTE 1: PRESENTACIÓN Y ENTRADA DE DATOS

Console.WriteLine("---------------- Control de Flujo ----------------\n");

Console.WriteLine("Área del triángulo");
double baseTriangulo = LeerMedida("Introduce la base: ");
double alturaTriangulo = LeerMedida("Introduce la altura: ");

Console.WriteLine("\nÁrea del cuadrado");
double ladoCuadrado = LeerMedida("Introduce el lado: ");

Console.WriteLine("\nÁrea del círculo");
double radioCirculo = LeerMedida("Introduce el radio: ");

Console.WriteLine("\nMayor o menor de edad");
int edad = LeerEdad();

// PARTE 2: LLAMADAS A LAS FUNCIONES Y RESULTADOS

Console.WriteLine("\n---------------- Resultados ----------------\n");

Console.WriteLine($"Triángulo — Base: {baseTriangulo}, altura: {alturaTriangulo}");
Console.WriteLine(
    $"Resultado: {Atriangulo(baseTriangulo, alturaTriangulo):F2} unidades cuadradas\n");

Console.WriteLine($"Cuadrado — Lado: {ladoCuadrado}");
Console.WriteLine(
    $"Resultado: {ACuadrado(ladoCuadrado):F2} unidades cuadradas\n");

Console.WriteLine($"Círculo — Radio: {radioCirculo}");
Console.WriteLine(
    $"Resultado: {ACirculo(radioCirculo):F2} unidades cuadradas\n");

Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Resultado: {CheckIfYoung(edad)}");

// PARTE 3: FUNCIONES DE CÁLCULO Y CLASIFICACIÓN DE EDAD

// Calcula el área del triángulo.
double Atriangulo(double a, double b)
{
    return a * b / 2;
}

// Calcula el área del cuadrado.
double ACuadrado(double lado)
{
    return lado * lado;
}

// Calcula el área del círculo.
double ACirculo(double r)
{
    const double PI = Math.PI;
    double rSquared = Math.Pow(r, 2);
    return PI * rSquared;
}

// Devuelve un mensaje según la edad recibida.
string CheckIfYoung(int year)
{
    if (year >= 18)
    {
        return "Mayor de edad";
    }

    return "Menor de edad";
}

// PARTE 4: LECTURA Y VALIDACIÓN DE DATOS

// Solicita una medida hasta recibir un número finito y positivo.
double LeerMedida(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);

        if (double.TryParse(Console.ReadLine(), out double valor)
            && double.IsFinite(valor)
            && valor > 0)
        {
            return valor;
        }

        Console.WriteLine("Introduce un número válido mayor que cero.");
    }
}

// Solicita una edad entera y no negativa.
int LeerEdad()
{
    while (true)
    {
        Console.Write("Introduce la edad en años: ");

        if (int.TryParse(Console.ReadLine(), out int edad)
            && edad >= 0)
        {
            return edad;
        }

        Console.WriteLine("Introduce una edad válida en números enteros.");
    }
}
