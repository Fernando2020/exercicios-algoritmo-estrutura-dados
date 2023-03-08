using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var formasGeometricas = new List<IFiguraGeometrica>
            {
                new Quadrado(2),
                new TrianguloEquilatero(2,3),
                new Circulo(2),
                new Quadrado(4),
                new TrianguloEquilatero(5,3),
                new Circulo(4)
            };

            formasGeometricas.ForEach(x => Console.WriteLine($"{x.Tipo} - Área: {x.CalcularArea()}"));
        }

        public static class NomeFiguraGeometrica
        {
            public const string Quadrado = "Quadrado";
            public const string TrianguloEquilatero = "Triângulo Equilátero";
            public const string Circulo = "Círculo";
        }

        public interface IFiguraGeometrica
        {
            public string Tipo { get; }
            public double CalcularArea();
        }

        public class Quadrado : IFiguraGeometrica
        {
            public string Tipo => NomeFiguraGeometrica.Quadrado;
            public double Lado { get; }

            public Quadrado(double lado)
            {
                Lado = lado;
            }

            public double CalcularArea()
            {
                return Lado * Lado;
            }
        }

        public class TrianguloEquilatero : IFiguraGeometrica
        {
            public string Tipo => NomeFiguraGeometrica.TrianguloEquilatero;
            public double Base { get; }
            public double Altura { get; }
            public TrianguloEquilatero(double bas, double altura)
            {
                Base = bas;
                Altura = altura;
            }

            public double CalcularArea()
            {
                return Base * Altura / 2;
            }
        }

        public class Circulo : IFiguraGeometrica
        {
            public string Tipo => NomeFiguraGeometrica.Circulo;
            public double Raio { get; }
            public Circulo(double raio)
            {
                Raio = raio;
            }

            public double CalcularArea()
            {
                return Math.PI * Raio * Raio;
            }
        }
    }
}
