using System;
using Entidades;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {

        //JuegoDao.EliminarDato(2);

        Juego juego = new Juego("CupHead", 500, "Ficcion", 3,21);

        JuegoDao.AgregarDato(juego);


    }
}