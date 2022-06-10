using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento.Modelo
{
    internal class Auto
    {
        //campos (Datos privados, para que esta informacion no sea publicamente tan accesible)
        //al declararlos puedo usarlos despues en propiedades para poder asignarlos u obtenerlos con el get y set
        //usamos guion bajo para diferenciar los campos de las propiedades
        private string _tipoDeMotor;
        private string _anioDeFabricacion;
        private bool _bujiasOkey;

        public string TipoDeMotor // al acceder a la Propiedad TipoDeMotor, digo que devuelva el private _tipoDeMotor
        {
            get { return _tipoDeMotor; } // get obtiene el valor del private _tipoDeMotor, usado en el Console.WriteLine(miAuto.TipoDeMotor) del programa principal
            set                         // con el set puedo manipular el valor que le estoy queriendo asignar al TipoDeMotor (enlazo la Propieda a un Campo de la clase)
            {
                if (value == null || value == "") // para que no se guarde un TipoDeMotor vacio
                {
                    _tipoDeMotor = "Nafta";
                }
                else
                {
                    _tipoDeMotor = value; //value hace referencia al valor que le ingresa externamente a la propiedad TipoDeMotor
                }
            }
        }


        //propiedades autoimplementadas, todas tienen un metodo {get y set}
        //si no defino un cuerpo (osea propiedad autoimplementada) se crea un campo (que no lo veo) dentro de la clase donde va a guardar los datos del get y set
        public bool EstaEncendido { get; set; } // get (obtener) y set (colocar) permiten que podamos manipular los datos y guardarlos en un campo
        public int AnioDeFabricacion { get; set; } // get y set no hacen mas que ingresar u obtener el valor de AnioDeFabricacion (aplica a todas las propiedades)
        public string Marca { get; set; }
        // la Propiedad procesa el valor que se le esta queriendo asignar a travez del SET, o el valor que se esta devolviendo cuando se invoca la Propidad a travez del GET 

    }
}
