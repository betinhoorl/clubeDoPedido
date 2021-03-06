﻿namespace ClubeDoPedido.Mobile.Model.Modelo
{
    public class Usuario
    {
        // Propriedades
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
        public string Foto { get; set; }
        public int? EnderecoID { get; set; }

        // Construtor
        public Usuario() {}
    }
}
