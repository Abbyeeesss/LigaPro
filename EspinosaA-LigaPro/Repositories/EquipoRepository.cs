﻿using EspinosaA_LigaPro.Models;

namespace EspinosaA_LigaPro.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> Equipo;
        public EquipoRepository()
        {
            Equipo = DevuelveListadoEquipos();
        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();


            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosPerdidos = 0,
                PartidosEmpatados = 0
            };

            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 9,
                PartidosPerdidos = 0,
                PartidosEmpatados = 0
            };
            equipos.Add(ldu);
            equipos.Add(barcelona);

            return equipos;
        }

        public Equipo DevuelveEquipoPorID(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = Equipo.First(item => item.Id == Id);

            return equipo;
        }

        public bool ActualizarEquipo(int Id, Equipo equipo)
        {
            //logica de actualizacion
            return true;

        }


    }
}