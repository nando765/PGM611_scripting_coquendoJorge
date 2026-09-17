
using UnityEngine;

namespace logica_de_jugador
{
    public class jugador : MonoBehaviour
    {

        private void Start()
        {

        }

        private void Update()
        {

        }

    }
}
public class Enemigo
{

}


#region Mundo
namespace herramientas
{
    namespace calculos
    {
        using logica_de_jugador;
        public class Ejemplo
        {
            public void metodoEjemplo()
            {
                Enemigo j = new Enemigo();
            }
        }
    }
    namespace conectividad
    {
        public partial class herramienta
        {

        }
    }
}

namespace niveles
{
    using herramientas.calculos;

    public class llamada
    {
        public void metodoLlamada()
        {
            Ejemplo e;
        }

    }

}
#endregion  

