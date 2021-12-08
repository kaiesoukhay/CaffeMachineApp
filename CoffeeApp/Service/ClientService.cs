using DataAcess.Models;
using Service.Interface;
using DataAcess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _ClientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _ClientRepository = clientRepository;
           
        }
        public Clients AddClient(Clients c)
            
        {
            try
            {
                var a = _ClientRepository.CreateClient(c);
                return c;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public Clients GetClintById(int Id)
        {

            Clients c = _ClientRepository.GetClietById(Id);
            return c;
        }
    }
}
