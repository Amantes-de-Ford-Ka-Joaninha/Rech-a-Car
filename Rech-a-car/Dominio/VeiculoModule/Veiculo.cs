using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Dominio.VeiculoModule
{
    public class Veiculo : Entidade
    {
        public Veiculo(string modelo, string marca, int ano, string placa, int capacidade, int portas, string chassi, int porta_malas, Image foto, bool automatico, string categoria, DadosVeiculo dadosVeiculo)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Placa = placa;
            Capacidade = capacidade;
            Portas = portas;
            Chassi = chassi;
            Porta_malas = porta_malas;
            Foto = foto;
            Automatico = automatico;
            Categoria = categoria;
            DadosVeiculo = dadosVeiculo;
        }

        public string Modelo { get; }
        public string Marca { get; }
        public string Categoria { get; }
        public string Placa { get; }
        public string Chassi { get; }
        public int Capacidade { get; }
        public int Portas { get; }
        public int Porta_malas { get; }
        public int Ano { get; }
        public Image Foto { get; }
        public bool Automatico { get; set; }
        public DadosVeiculo DadosVeiculo { get; }

        public string PortaMalaToString()
        {
            if (Porta_malas == 0)
                return "Pequeno";
            if (Porta_malas == 1)
                return "Médio";
            else
                return "Grande";
        }
        public string CambioToString()
        {
            if (Automatico)
                return "Automático";
            else
                return "Manual";
        }
        public override string Validar()
        {
            Regex templatePlacaMercoSul = new Regex(@"\b[A-Z]{3}[0-9][A-Z][0-9]{2}\b");
            Regex templatePlacaAntiga = new Regex(@"\b[A-Z]{3}[0-9][0-9]{3}\b");
            Regex templateChassi = new Regex(@"\b[0-9]{1}[A-Z]{2}[0-9]{2}[A-Z]{1}[0-9]{8}\b");

            string validacao = "";

            if (String.IsNullOrEmpty(Modelo))
                validacao += "Modelo do veículo é obrigatório";

            if (String.IsNullOrEmpty(Marca))
                validacao += "Marca do veículo é obrigatória";

            if (String.IsNullOrEmpty(Categoria))
                validacao += "Categoria do veículo é obrigatória";

            if (!templatePlacaAntiga.IsMatch(Placa) && !templatePlacaMercoSul.IsMatch(Placa))
                validacao += "Placa do veículo inválida";

            if (!templateChassi.IsMatch(Chassi))
                validacao += "Chassi do veículo inválido";

            if (Capacidade > 0)
                validacao += "Capacidade deve ser maior que 0";

            if (Portas > 1)
                validacao += "Deve ter pelo menos duas Portas";

            if (Porta_malas > 0)
                validacao += "Volume do Porta-malas inválido";

            if (Ano > DateTime.Now.Year + 1)
                validacao += "Ano do carro inválido";

            validacao += DadosVeiculo.Validar();

            if (validacao == Valido)
                return Valido;

            return validacao;
        }
    }
}
