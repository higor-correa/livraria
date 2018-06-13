using System;

namespace Livraria.Domain.Dtos
{
    public class LivroResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public string Autor { get; set; }
        public DateTime? DataLancamento { get; set; }
    }
}
