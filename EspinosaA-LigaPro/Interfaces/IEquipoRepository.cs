using EspinosaA_LigaPro.Models;

namespace EspinosaA_LigaPro.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo(Equipo equipo);
        bool EditarEquipo(Equipo equipo);
        bool EliminarEquipo(int id);
    }
}