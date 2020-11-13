namespace ListaCircularEjemplo
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo()
        {
            dato = 0;
            siguiente = null;
        }

        public Nodo(int dato, Nodo siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
