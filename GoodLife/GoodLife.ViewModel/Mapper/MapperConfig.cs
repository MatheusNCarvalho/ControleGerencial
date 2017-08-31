using System.Net.Http;
using GoodLife.Domain.Entidades.Administracao;
using GoodLife.ViewModel.Modulos.Administracao;

namespace GoodLife.ViewModel.Mapper
{
    public class MapperConfig
    {
        
        
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(c =>
            {
                c.CreateMap<Pessoa, PessoaModel>().ReverseMap();
                c.CreateMap<Endereco, EnderecoModel>().ReverseMap();



            });
            AutoMapper.Mapper.AssertConfigurationIsValid();
        }
    }
}
