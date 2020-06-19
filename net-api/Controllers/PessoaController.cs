using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using net_api.Models;

namespace net_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private List<Pessoa> _pessoas;

        public PessoaController()
        {
            _pessoas = new List<Pessoa>();
            var pessoa1 = new Pessoa(
                1,
                "Beerg",
                50,
                "143,444,555-23"
                );
            var pessoa2 = new Pessoa(
                1,
                "limao",
                80,
                "144,244,535-23"
                );
            _pessoas.Add(pessoa1);
            _pessoas.Add(pessoa2);


        }
        [HttpGet]
        public IEnumerable<Pessoa> GetPessoas()
        {
            return _pessoas;
        }

        [HttpPost]
        public Pessoa CriarPessoa(Pessoa pessoa)
        {
            _pessoas.Add(pessoa);
            return pessoa;
        }

        [HttpPut]
        public string AtualizarPessoa(Pessoa pessoa)
        {
            var index = _pessoas.IndexOf(_pessoas.Where(X => X.Id == pessoa.Id).First());
            _pessoas.RemoveAt(index);
            _pessoas.Insert(index, pessoa);
            return "Pessoa ATualizada com sucesso";

        }

        [HttpPatch]
        public string AtulizarNome(Pessoa pessoa)
        {
            var index = _pessoas.IndexOf(_pessoas.Where(X => X.Id == pessoa.Id).First());
            _pessoas.RemoveAt(index);
            _pessoas.Insert(index, pessoa);
            return "Nome atualizado com sucesso";
        }

        [HttpDelete]
        [Route("deletar{id}")]
        public bool DeletarPessoa(int id)
        {
            var index = _pessoas.IndexOf(_pessoas.Where(X => X.Id == id).First());
            _pessoas.RemoveAt(index);
            return true;
        }

    }
}
