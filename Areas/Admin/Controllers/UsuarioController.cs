 using LICEORURALJASMINEZ.Utilidades;
using LICEORURALJASMINEZB.Claims;
using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static LICEORURALJASMINEZB.Models.ClaimsUsuarioViewModel;

namespace LICEORURALJASMINEZB.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class UsuarioController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _contexto;
        public UsuarioController(UserManager<IdentityUser> userManager, ApplicationDbContext contexto)
        {
            _userManager = userManager;
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var usuarios = await _contexto.ApplicationUser.ToListAsync();
            var rolesUsuario = await _contexto.UserRoles.ToListAsync();
            var roles = await _contexto.Roles.ToListAsync();
            foreach (var usuario in usuarios)
            {
                var rol = rolesUsuario.FirstOrDefault(u => u.UserId == usuario.Id);
                if (rol == null)
                {
                    usuario.Role = "Ninguno";
                }
                else
                {
                    usuario.Role = roles.FirstOrDefault(u => u.Id == rol.RoleId).Name;
                }
            }

            return View(usuarios);
        }
        [HttpGet]
        public IActionResult Editar(string id)
        {
            var usuarioBD = _contexto.ApplicationUser.FirstOrDefault(u => u.Id == id);
            if (usuarioBD == null)
            {
                return NotFound();
            }
            //Obtner los roles actuales del usuario 
            var rolUsuario = _contexto.UserRoles.ToList();
            var roles = _contexto.Roles.ToList();
            var rol = rolUsuario.FirstOrDefault(u => u.UserId == usuarioBD.Id);
            if (rol != null)
            {
                usuarioBD.IdRol = roles.FirstOrDefault(u => u.Id == rol.RoleId).Id;
            }
            usuarioBD.ListaRoles = _contexto.Roles.Select(u => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = u.Name,
                Value = u.Id
            });

            return View(usuarioBD);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = DS.Role_Admin)]
        public async Task<IActionResult> Editar(ApplicationUser usuario)
        {

            if (ModelState.IsValid)
            {
                var usuarioBD = _contexto.ApplicationUser.FirstOrDefault(u => u.Id == usuario.Id);
                if (usuarioBD == null)
                {
                    return NotFound();
                }

                var rolUsuario = _contexto.UserRoles.FirstOrDefault(u => u.UserId == usuarioBD.Id);
                if (rolUsuario != null)
                {
                    //Obtener el rol actual
                    var rolActual = _contexto.Roles.Where(u => u.Id == rolUsuario.RoleId).Select(e => e.Name).FirstOrDefault();
                    //Eliminar el rol actual
                    await _userManager.RemoveFromRoleAsync(usuarioBD, rolActual);
                }

                //Agregar usuario al nuevo rol seleccionado
                await _userManager.AddToRoleAsync(usuarioBD, _contexto.Roles.FirstOrDefault(u => u.Id == usuario.IdRol).Name);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            usuario.ListaRoles = _contexto.Roles.Select(u => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = u.Name,
                Value = u.Id
            });

            return View(usuario);
        }

        [HttpGet]
        public IActionResult EditarPerfil(string id)
        {

            if (id == null)
            {
                return NotFound();
            }
            //Obtner los roles actuales del usuario 
            var usuarioDB = _contexto.ApplicationUser.Find(id);
            if (usuarioDB == null)
            {
                return NotFound();
            }
            return View(usuarioDB);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BloquearDesbloquear(string idUsuario)
        {

            var usuariBD = _contexto.ApplicationUser.FirstOrDefault(u => u.Id == idUsuario);
            if (usuariBD == null)
            {
                return NotFound();
            }

            if (usuariBD.LockoutEnd != null && usuariBD.LockoutEnd > DateTime.Now)
            {
                //El usuario se encuentra bloqueado y lo podemos desbloquear
                usuariBD.LockoutEnd = DateTime.Now;
                TempData["Correcto"] = "Usuario desbloqueado correctamente";
            }
            else
            {
                //El usuario no está bloqueado y lo podemos bloquear
                usuariBD.LockoutEnd = DateTime.Now.AddYears(100);
                TempData["Error"] = "Usuario bloqueado correctamente";
            }

            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _contexto.Users.FindAsync(id);
            if (user == null)
            {
                return View();
            }
            _contexto.Users.Remove(user);
            await _contexto.SaveChangesAsync();
            TempData["Correcto"] = "Usuario borrado correctamente";
            return RedirectToAction(nameof(Index));
        }


        //Manejo de claims
        [HttpGet]
        public async Task<IActionResult> AdministrarClaimsUsuario(string idUsuario)
        {
            IdentityUser usuario = await _userManager.FindByIdAsync(idUsuario);
            if (usuario == null)
            {
                return NotFound();
            }

            var claimUsuarioActual = await _userManager.GetClaimsAsync(usuario);

            var modelo = new ClaimsUsuarioViewModel()
            {
                IdUsuario = idUsuario
            };

            foreach (Claim claim in ManejoClaims.listaClaims)
            {
                ClaimUsuario claimUsuario = new ClaimUsuario
                {
                    TipoClaim = claim.Type
                };
                if (claimUsuarioActual.Any(c => c.Type == claim.Type))
                {
                    claimUsuario.Seleccionado = true;
                }
                modelo.Claims.Add(claimUsuario);
            }

            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> AdministrarClaimsUsuario(ClaimsUsuarioViewModel cuViewModel)
        {
            IdentityUser usuario = await _userManager.FindByIdAsync(cuViewModel.IdUsuario);
            if (usuario == null)
            {
                return NotFound();
            }

            var claims = await _userManager.GetClaimsAsync(usuario);
            var resultado = await _userManager.RemoveClaimsAsync(usuario, claims);

            if (!resultado.Succeeded)
            {
                return View(cuViewModel);
            }

            resultado = await _userManager.AddClaimsAsync(usuario, cuViewModel.Claims.Where(c => c.Seleccionado)
                .Select(c => new Claim(c.TipoClaim, c.Seleccionado.ToString())));

            if (!resultado.Succeeded)
            {
                return View(cuViewModel);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
