using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios
{
   public class ManagerIdioma
{
        static List<IObserverIdioma> observers = new List<IObserverIdioma>();
        private ManagerIdioma() { }

        private static ManagerIdioma managerIdioma;

        public Modelo.Idioma Idioma { get; set; }

        public static ManagerIdioma GetInstance()
        {
            if (managerIdioma == null)
            {
                managerIdioma = new ManagerIdioma();
            }

            return managerIdioma;
        }

        //Manejo multi-idiomas.
        public static void Suscribir(IObserverIdioma o)
        {
            observers.Add(o);
        }
        public static void Desuscribir(IObserverIdioma o)
        {
            observers.Remove(o);
        }

        private static void Notificar(Modelo.Idioma idioma)
        {
            foreach (var o in observers)
            {
                o.ActualizarIdioma(idioma);
            }
        }
        public static void CambiarIdioma(Modelo.Idioma idioma)
        {
            if (managerIdioma != null)
            {
                managerIdioma.Idioma = idioma;
                Notificar(idioma);
            }
        }

        public static void AsignarIdioma(Modelo.Idioma idioma)
        {
            if (managerIdioma != null)
            {
                managerIdioma.Idioma = idioma;
            }
        }
    }
}
