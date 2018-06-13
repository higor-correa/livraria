using AutoMapper;
using Livraria.Bll.Exceptions;
using Livraria.Bll.Interfaces;
using Livraria.Dal.Interfaces;
using Livraria.Domain.Dtos;
using Livraria.Domain.Entities;
using System.Collections.Generic;

namespace Livraria.Bll
{
    public class LivroBll : ILivroBll
    {
        private readonly ILivroDal _livroDal;
        private readonly IMapper _mapper;

        public LivroBll(IMapper mapper, ILivroDal livroDal)
        {
            _livroDal = livroDal;
            _mapper = mapper;
        }

        public void Alterar(int id, LivroRequestDto request)
        {
            var entity = _livroDal.Obter(id);
            if (entity == null)
                throw new EntityNotFoundException();

            entity = _mapper.Map<LivroEntity>(request);
            entity.Id = id;

            _livroDal.Alterar(entity);
        }

        public int Inserir(LivroRequestDto request)
        {
            var entity = _mapper.Map<LivroEntity>(request);
            _livroDal.Inserir(entity);
            return entity.Id;
        }

        public List<LivroResponseDto> Listar()
        {
            var lista = _livroDal.Listar();
            return _mapper.Map<List<LivroResponseDto>>(lista);
        }

        public LivroResponseDto Obter(int id)
        {
            var entity = _livroDal.Obter(id);
            if (entity == null)
                throw new EntityNotFoundException();

            var response = _mapper.Map<LivroResponseDto>(entity);
            return response;
        }

        public void Remover(int id)
        {
            var livro = _livroDal.Obter(id);
            if (livro == null)
                throw new EntityNotFoundException();

            _livroDal.Remover(livro);
        }
    }
}
