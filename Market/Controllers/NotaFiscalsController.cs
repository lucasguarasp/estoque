using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Market.Models;
using Market.Services;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Market.Controllers
{
    public class NotaFiscalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotaFiscalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NotaFiscals
        public async Task<IActionResult> Index()
        {
            return View(await _context.NotaFiscais.Where(p => p.DataExclusao == null).ToListAsync());
        }

        // GET: NotaFiscals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscais
                .FirstOrDefaultAsync(m => m.IdNotaFiscal == id);
            if (notaFiscal == null)
            {
                return NotFound();
            }

            return View(notaFiscal);
        }

        // GET: NotaFiscals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NotaFiscals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNotaFiscal,Descricao,DataInclusao,DataExclusao,Arquivo")] NotaFiscal notaFiscal)
        {
            if (ModelState.IsValid)
            {
                notaFiscal.DataInclusao = DateTime.Now;
                _context.NotaFiscais.Add(notaFiscal);

                var caminho = FileService.InserirArquivo(notaFiscal.Arquivo);
                var arquivo = new Arquivo { NotaFiscal = notaFiscal, Caminho = caminho, DataInclusao = notaFiscal.DataInclusao };
                _context.Arquivos.Add(arquivo);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(notaFiscal);
        }

        // GET: NotaFiscals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscais.FindAsync(id);
            if (notaFiscal == null)
            {
                return NotFound();
            }
            return View(notaFiscal);
        }

        // POST: NotaFiscals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNotaFiscal,Descricao,DataInclusao,DataExclusao")] NotaFiscal notaFiscal)
        {
            if (id != notaFiscal.IdNotaFiscal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaFiscal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaFiscalExists(notaFiscal.IdNotaFiscal))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(notaFiscal);
        }

        // GET: NotaFiscals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscais
                .FirstOrDefaultAsync(m => m.IdNotaFiscal == id);
            if (notaFiscal == null)
            {
                return NotFound();
            }

            return View(notaFiscal);
        }

        // POST: NotaFiscals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            NotaFiscal notaFiscal = await _context.NotaFiscais.FindAsync(id);
            notaFiscal.DataExclusao = DateTime.Now;
            _context.NotaFiscais.Update(notaFiscal);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaFiscalExists(int id)
        {
            return _context.NotaFiscais.Any(e => e.IdNotaFiscal == id);
        }

        public async Task<IActionResult> DownloadNota(int? id)
        {
            Arquivo file = await NewMethod(id);

            if (file == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", file.Caminho);

            return File(System.IO.File.ReadAllBytes(file.Caminho), FileService.GetContentType(path), file.Caminho);
        }

        private async Task<Arquivo> NewMethod(int? id)
        {
            return await _context.Arquivos.Include(p => p.NotaFiscal).FirstOrDefaultAsync(m => m.NotaFiscal.IdNotaFiscal == id);
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats officedocument.spreadsheetml.sheet"},  
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
    }
}
