using EspinosaA_LigaPro.Models;
using EspinosaA_LigaPro.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace EspinosaA_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;

        public EquipoController()

            {
            _repository = new EquipoRepository();

        }


        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {

            var equipos = _repository.DevuelveListadoEquipos();

            equipos = equipos.OrderBy(item => item.PartidosGanados);
            //equipos = equipos.Where(item => item.Nombre == "Liga de Quito"); 

            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveEquipoPorID(Id);
            return View(equipo);

        }
        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            //proceso de guardar
            try
            {
                EquipoRepository repository = new EquipoRepository();
                repository.ActualizarEquipo(Id, equipo); 
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }

        }

    }
}