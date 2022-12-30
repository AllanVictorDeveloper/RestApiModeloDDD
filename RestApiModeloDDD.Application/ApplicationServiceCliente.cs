using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        public void Add(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }
    }
}
