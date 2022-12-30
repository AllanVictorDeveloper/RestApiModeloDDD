using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        IEnumerable<ClienteDto> clienteDtos = new List<ClienteDto>();

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {

                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                SobreNome = clienteDto.SobreNome,
                Email = clienteDto.Email

            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {

                Id = cliente.Id,
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email

            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes)
        {
            throw new NotImplementedException();
        }
    }
}
