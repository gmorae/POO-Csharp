﻿using System;
using Treinando_classes.Models;
namespace Treinando_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleTv ctrl = new ControleTv();

            Console.WriteLine("O controle tem botão ?");
            string resposta = Console.ReadLine();
            ctrl.botao = verificaBool(resposta);
            Console.WriteLine("Digite a cor do botão: ");
            ctrl.color = Console.ReadLine();
            Console.WriteLine("O controle tem sensor ?");
            resposta = Console.ReadLine();
            ctrl.sensor = verificaBool(resposta);

            Console.WriteLine("Digite o tamanho: ");
            ctrl.tamanho = double.Parse(Console.ReadLine());

            Console.WriteLine($@"
            Botão => {ctrl.botao}
            Cor => {ctrl.color}
            Sensor => {ctrl.sensor}
            Tamanho => {ctrl.tamanho} cm
            ");
        }
        public static bool verificaBool(string resposta)
        {
            resposta = resposta.ToUpper();
            if (resposta == "SIM")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
