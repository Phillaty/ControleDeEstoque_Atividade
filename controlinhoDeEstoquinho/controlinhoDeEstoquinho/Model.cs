using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlinhoDeEstoquinho
{
    public class Model
    {
        internal void setUsuario(DtoUsuario u)
        {
            context db = new context();
            db.usuario.Add(u);
            db.SaveChanges();
        }

        internal void setProduto(DtoProduto u)
        {
            context db = new context();
            db.produto.Add(u);
            db.SaveChanges();
        }

        internal void setVenda(DtoVenda u)
        {
            context db = new context();
            db.venda.Add(u);
            db.SaveChanges();
        }

        internal List<DtoUsuario> GetUsuarios()
        {
            context db = new context();
            //List<DtoUsuario> retorno = (from u in db.usuario select new DtoUsuario
            //{
            //    id = u.id,
            //    nome = u.nome
            //}).ToList();

            List<DtoUsuario> retorno = db.usuario.ToList();

            return new List<DtoUsuario>(retorno);
        }

        internal List<DtoProduto> GetProdutos()
        {
            context db = new context();

            List<DtoProduto> retorno = db.produto.ToList();

            return new List<DtoProduto>(retorno);
        }

        internal List<DtoVenda> GetVenda()
        {
            context db = new context();

            List<DtoVenda> retorno = db.venda.ToList();

            return new List<DtoVenda>(retorno);
        }

        internal DtoUsuario GetUsuariosId(int id)
        {
            context db = new context();

            //var resultado = (from u in db.usuario where u.id == id select new DtoUsuario
            //{
            //    id = u.id,
            //    nome = u.nome,
            //    login = u.login,
            //}).FirstOrDefault();

            var resultado1 = db.usuario.Where(u => u.id == id).FirstOrDefault();

            return resultado1;
        }

        internal DtoProduto GetProdutosId(int id)
        {
            context db = new context();

            var resultado = db.produto.Where(u => u.id == id).FirstOrDefault();

            return resultado;
        }

        internal DtoVenda GetVendaId(int id)
        {
            context db = new context();

            var resultado = db.venda.Where(u => u.idproduto == id).FirstOrDefault();

            return resultado;
        }

        internal void EditUsuario(DtoUsuario u)
        {
            context db = new context();
            DtoUsuario e = db.usuario.FirstOrDefault(p => p.id == u.id);
            e.nome = u.nome;
            e.login = u.login;
            e.senha = u.senha;

            db.SaveChanges();
        }

        internal void EditVenda(DtoVenda u)
        {
            context db = new context();
            DtoVenda e = db.venda.FirstOrDefault(p => p.id == u.id);
            e.valorvenda = u.valorvenda;
            e.quantidade = u.quantidade;

            db.SaveChanges();
        }

        internal void EditQtdProduto(DtoProduto u)
        {
            context db = new context();
            DtoProduto e = db.produto.FirstOrDefault(p => p.id == u.id);
            e.quantidade = u.quantidade;

            db.SaveChanges();
        }

        internal void EditProduto(DtoProduto u)
        {
            context db = new context();
            DtoProduto e = db.produto.FirstOrDefault(p => p.id == u.id);
            e.nome = u.nome;
            e.quantidade = u.quantidade;
            e.marca = u.marca;
            e.preco = u.preco;

            db.SaveChanges();
        }

        public void DeletarUsuario(int id)
        {
            context db = new context();
            DtoUsuario u = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(u);
            db.SaveChanges();
        }

        public void DeletarProduto(int id)
        {
            context db = new context();
            DtoProduto u = db.produto.FirstOrDefault(p => p.id == id);
            db.produto.Remove(u);
            db.SaveChanges();
        }
    }
}
