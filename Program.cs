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
