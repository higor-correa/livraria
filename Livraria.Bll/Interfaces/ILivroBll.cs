using Livraria.Domain.Dtos;
using System.Collections.Generic;

namespace Livraria.Bll.Interfaces
{
    public interface ILivroBll
    {
        List<LivroResponseDto> Listar();
        LivroResponseDto Obter(int id);
        int Inserir(LivroRequestDto request);
        void Alterar(int id, LivroRequestDto request);
        void Remover(int id);
    }
}
