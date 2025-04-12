using EspinosaA_LigaPro.Models;
using EspinosaA_LigaPro.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EspinosaA_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            EquipoRepository equipoRepository = new EquipoRepository();
            var equipos = equipoRepository.DevuelveListadoEquipos();

            equipos = equipos.OrderBy(item => item.PartidosGanados);
            //equipos = equipos.Where(item => item.Nombre == "Liga de Quito"); 

            return View(equipos);
        }
    }
}