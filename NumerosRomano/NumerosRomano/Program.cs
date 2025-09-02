namespace NumerosRomano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número Romano: ");
            string numeroRomano = Console.ReadLine().ToUpper();
            int resultado = 0;
            int repeticionesI = 0;
            int repeticionesX = 0;
            int repeticionesC = 0;
            int repeticionesM = 0;

            if (numeroRomano.Contains("I") || numeroRomano.Contains("V") || numeroRomano.Contains("X") || numeroRomano.Contains("L") || numeroRomano.Contains("C") || numeroRomano.Contains("D") || numeroRomano.Contains("M")) 
            {
                for (int i = 0; i < numeroRomano.Length; i++)
                {
                    char letra = numeroRomano[i];
                    char siguienteLetra = i + 1 < numeroRomano.Length ? numeroRomano[i + 1] : '\0';

                    if (letra == 'I' && (siguienteLetra == 'X' || siguienteLetra == 'L' || siguienteLetra == 'C' || siguienteLetra == 'D' || siguienteLetra == 'M'))
                    {
                        Console.WriteLine("El número ingresado no es un número Romano válido.");
                        return;
                    }
                    else if (letra == 'V' && (siguienteLetra == 'X' || siguienteLetra == 'L' || siguienteLetra == 'C' || siguienteLetra == 'D' || siguienteLetra == 'M'))
                    {
                        Console.WriteLine("El número ingresado no es un número Romano válido.");
                        return;
                    }
                    else if (letra == 'X' && (siguienteLetra == 'D' || siguienteLetra == 'M'))
                    {
                        Console.WriteLine("El número ingresado no es un número Romano válido.");
                        return;
                    }
                    else if (letra == 'L' && (siguienteLetra == 'C' || siguienteLetra == 'D'))
                    {
                        Console.WriteLine("El número ingresado no es un número Romano válido.");
                        return;
                    }
                    else if (letra == 'D' && siguienteLetra == 'M')
                    {
                        Console.WriteLine("El número ingresado no es un número Romano válido.");
                        return;
                    }


                    if (letra == 'I' && (siguienteLetra != 'V' && siguienteLetra != 'X'))
                    {
                        if (repeticionesI == 3)
                        {
                            Console.WriteLine("El número ingresado no es un número Romano válido.");
                            return;
                        }
                        repeticionesI++;

                        resultado += 1;

                    }
                    else if (letra == 'I' && siguienteLetra == 'V')
                    {
                        resultado += 4;
                        i++;

                    }
                    else if (letra == 'V' && (siguienteLetra != 'X' && siguienteLetra != 'V' && siguienteLetra != 'L' && siguienteLetra != 'C' && siguienteLetra != 'D'))
                    {

                        resultado += 5;
                    }
                    else if (letra == 'I' && siguienteLetra == 'X')
                    {
                        resultado += 9;
                        i++;
                        //pera 
                    }

                    
                    else if (letra == 'X' && siguienteLetra == 'L')
                    {
                        resultado += 40;
                        i++;
                    }

                    
                    else if (letra == 'X' && siguienteLetra == 'C')
                    {
                        resultado += 90;
                        i++;
                    }
                    
                    else if (letra == 'C' && siguienteLetra == 'D')
                    {
                        resultado += 400;
                        i++;
                    }
                    
                    else if (letra == 'C' && siguienteLetra == 'M')
                    {
                        resultado += 900;
                        
                        i++;
                    }

                    else if (letra == 'L')
                    {
                        resultado += 50;
                    }
                    else if (letra == 'D')
                    {
                        resultado += 500;
                    }
                    else if (letra == 'C')
                    {
                        if (repeticionesC == 3)
                        {
                            Console.WriteLine("El número ingresado no es un número Romano válido.");
                            return;
                        }
                        resultado += 100;
                        repeticionesC++;
                    }
                    else if (letra == 'M')
                    {
                        if (repeticionesM == 3)
                        {
                            Console.WriteLine("El número ingresado no es un número Romano válido.");
                            return;
                        }
                        resultado += 1000;
                        repeticionesM++;
                    }
                    else if (letra == 'X')
                    {
                        if (repeticionesX == 3)
                        {
                            Console.WriteLine("El número ingresado no es un número Romano válido.");
                            return;
                        }
                        resultado += 10;
                        repeticionesX++;
                    }
                } 
            }
            else
            {
                Console.WriteLine("El número ingresado no es un número Romano válido.");
            }

            Console.WriteLine("El número Romano en número decimal es: " + resultado);
        }

    }
}
