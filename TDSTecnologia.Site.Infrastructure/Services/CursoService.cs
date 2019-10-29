using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TDSTecnologia.Site.Core.Entities;
using TDSTecnologia.Site.Infrastructure.Data;
using TDSTecnologia.Site.Infrastructure.Repository;
using X.PagedList;

namespace TDSTecnologia.Site.Infrastructure.Services
{
    public class CursoService : BasicService
    {
        private readonly CursoRespository _cursoRespository;

        public CursoService(AppContexto context) : base(context)
        {
            _cursoRespository = new CursoRespository(context);
        }

        public List<Curso> ListarTodos()
        {
            return _cursoRespository.ListarTodos();
        }

        public Curso PesquisarPorId(int? id)
        {
            return _cursoRespository.PesquisarPorId(id);
        }

        public void Alterar(Curso curso)
        {
            _cursoRespository.Alterar(curso);
            SaveChangesApp();
        }

        public void Excluir(int? id)
        {
            var curso = PesquisarPorId(id);
            _cursoRespository.Excluir(curso);
            SaveChangesApp();
        }

        public void Incluir(Curso curso)
        {
            _context.Add(curso);
            SaveChangesApp();
        }
        public List<Curso> PesquisarPorNomeDescricao(string texto)
        {
            List<Curso> cursos = _cursoRespository.PesquisarPorNomeDescricao(texto);

            return cursos;
        }

        public IPagedList<Curso> ListarComPaginacao(int? pagina)
        {
            return _cursoRespository.ListarComPaginacao(pagina); ;
        }
    }
}
