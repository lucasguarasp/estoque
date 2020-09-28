using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Market.Models;
using Market.Services;
using Market.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Market.Controllers
{
  
    public class AdministrativaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdministrativaController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize]
        public IActionResult Index()
        {            
            var nome = HttpContext.User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Name).Value;
            ViewBag.Nome = nome;

            ObterContadores();

            return View();        

        }

        public IActionResult CadastroCliente()
        {
            return View();
        }        

        [HttpPost]
        public IActionResult CadastroCliente(ViewModelCadastro Cad)
        {            
            var endereco = new Endereco { Cep = Cad.Endereco.Cep, Bairro = Cad.Endereco.Bairro, Rua = Cad.Endereco.Rua, Numero = Cad.Endereco.Numero, Cidade = Cad.Endereco.Cidade, Complemento = Cad.Endereco.Complemento };
            _db.Enderecos.Add(endereco);

            var cadastro = new Usuario
            {
                Nome = Cad.Cadastro.Nome,
                Email = Cad.Cadastro.Email,
                Cpf = Cad.Cadastro.Cpf.Replace(".", "").Replace("-", ""),
                DataNascimento = Cad.Cadastro.DataNascimento,
                Password = HashService.Crip(Cad.Cadastro.Cpf.Replace(".", "").Replace("-", "")),
                Telefone = Cad.Cadastro.Telefone,
                Celular = Cad.Cadastro.Celular,
                Sexo = Cad.Cadastro.Sexo,
                TipoDeUsuarioId = 3,
                EnderecoId = endereco.IdEndereco,
                Status = true
            };

            _db.Cadastros.Add(cadastro);

            if (ModelState.IsValid)
            {
                _db.SaveChanges();
            }

            return RedirectToAction("CadastroCliente");
        }

        public void ObterContadores() {
            ViewBag.Produtos = 0;
            ViewBag.Usuarios = 0;
            ViewBag.NotasFicais = 0;
            ViewBag.Pedidos = 0;
        }

    }
}