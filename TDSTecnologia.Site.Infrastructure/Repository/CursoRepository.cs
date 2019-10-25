using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDSTecnologia.Site.Core.Entities;
using TDSTecnologia.Site.Core.Utilitarios;
using TDSTecnologia.Site.Infrastructure.Data;

namespace TDSTecnologia.Site.Infrastructure.Repository
{
    public class CursoRespository : BasicRepository
    {
        public CursoRespository(AppContexto context) : base(context)
        {
        }

        public List<Curso> ListarTodos()
        {
            return _context.CursoDao.ToList();
        }

        public void Incluir(Curso curso)
        {
            _context.Add(curso);
        }

        public void Alterar(Curso curso)
        {
            _context.Update(curso);
            _context.Entry<Curso>(curso).Property(c => c.Banner).IsModified = false;
        }

        public void Excluir(Curso curso)
        {
            _context.CursoDao.Remove(curso);
        }

        public Curso PesquisarPorId(int? id)
        {
            return _context.CursoDao.Find(id);
        }

        private void RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }
    }
}
