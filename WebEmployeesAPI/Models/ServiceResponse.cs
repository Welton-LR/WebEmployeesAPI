﻿namespace WebEmployeesAPI.Models
{
    public class ServiceResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Departamento { get; set; }
        public bool Ativo { get; set; }
        public string Turno { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeModificacao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
