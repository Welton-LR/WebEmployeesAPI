using System.Collections.Generic;
using WebEmployeesAPI.DataContext;
using WebEmployeesAPI.Models;

namespace WebEmployeesAPI.Service.FuncionarioService
{
    public class FuncionarioService : InterfaceFuncionario
    {   private readonly AplicationDbContext _context;
        public FuncionarioService(AplicationDbContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionarios(FuncionarioModel novoFuncionario)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

            try
            {
                serviceResponse.Dados = _context.Funcionario.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
