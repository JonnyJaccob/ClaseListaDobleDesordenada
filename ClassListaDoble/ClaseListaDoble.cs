using System;

namespace ClassListaDoble
{
    class ClaseListaDoble<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        public ClaseListaDoble(bool blnRepetir)
        {
            this.NodoInicial = null;
            this.NodoFinal = null;
            Repetir = blnRepetir;
        }
        bool Repetir;
        private ClaseNodo<Tipo> _NodoInicial;

        public ClaseNodo<Tipo> NodoInicial
        {
            get { return _NodoInicial; }
            set { _NodoInicial = value; }
        }
        private ClaseNodo<Tipo> _NodoFinal;

        public ClaseNodo<Tipo> NodoFinal
        {
            get { return _NodoFinal; }
            set { _NodoFinal = value; }
        }
        bool vacio
        {
            get
            {
                if (this.NodoInicial == null && this.NodoFinal == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void AgregarNodo(Tipo objeto)
        {
            if (vacio)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                nodoNuevo.Siguiente = null;
                this.NodoInicial = nodoNuevo;
                this.NodoFinal = nodoNuevo;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                nodoAnterior = nodoActual;
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos) && Repetir != false)
                    {
                        throw new Exception("Duplicado");
                    }
                    else
                    {
                        nodoAnterior = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                try
                {
                    ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                    nodoNuevo.ObjetoConDatos = objeto;
                    nodoNuevo.Previo = NodoFinal;
                    nodoNuevo.Siguiente = null;
                    NodoFinal.Siguiente = nodoNuevo;
                    NodoFinal = nodoNuevo;
                }
                catch (Exception ex)
                {

                    throw new Exception($"{ex}");
                }

            }

        }
        public Tipo BuscarNodo(Tipo objeto)
        {
            if (vacio)
            {
                throw new Exception("Esta vacio");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        return (nodoActual.ObjetoConDatos);

                    }
                    else
                    {
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
            }
            throw new Exception("No se encontro");
        }
        public Tipo EliminarNodo(Tipo objeto)
        {
            if (vacio)
            {
                throw new Exception("Esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
                nodoActual = this.NodoInicial;
                nodoAnterior = this.NodoFinal;
                if (objeto.Equals(NodoInicial.ObjetoConDatos))
                {
                    if (NodoInicial.Siguiente == null)
                    {
                        NodoInicial = null;
                        NodoFinal = null;
                        nodoEliminado = nodoActual;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    else
                    {
                        NodoInicial = nodoActual.Siguiente;
                        NodoFinal = null;
                        nodoEliminado = nodoActual;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                }
                else
                {
                    do
                    {
                        if (objeto.Equals(nodoActual.ObjetoConDatos))
                        {
                            if (objeto.Equals(NodoFinal.ObjetoConDatos))
                            {
                                nodoAnterior.Siguiente = null;
                                NodoFinal = nodoAnterior;
                                nodoEliminado = nodoActual;
                                nodoActual = null;
                                return nodoEliminado.ObjetoConDatos;
                            }
                            else
                            {
                                nodoAnterior.Siguiente = nodoActual.Siguiente;
                                nodoActual.Siguiente = nodoAnterior.Previo;
                                nodoEliminado = nodoActual;
                                //nodoActual = default(ClaseNodo<Tipo>);
                                nodoActual = null;
                                return nodoEliminado.ObjetoConDatos;
                            }
                        }
                        nodoAnterior = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    } while (nodoActual != null);
                }
            }
            throw new Exception("No se encontro ningun objeto");
        }
        public int ObtenerResultado(Tipo objeto)
        {
            ClaseNodo<Tipo> NodoPrevio = this.NodoInicial;
            ClaseNodo<Tipo> NodoActual = NodoPrevio.Siguiente;
            int x = objeto.CompareTo(NodoActual.ObjetoConDatos);

            return x;
        }

        public void VaciarLista()
        {
            if (vacio)
            {

            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                while (nodoActual != null)
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                }
                nodoPrevio = null;
                NodoInicial = null;
                NodoFinal = null;
            }
        }
        public IEnumerator<Tipo> GetEnumerator()
        {
            if (vacio)
            {
                yield break;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                while (nodoActual != null)
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;
                }
                yield break;
            }
        }
        public IEnumerable<Tipo> HaciaAtras
        {
            get
            {
                if (vacio)
                {
                    yield break;
                }
                else
                {
                    ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                    nodoActual = NodoFinal;
                    do
                    {
                        yield return nodoActual.ObjetoConDatos;
                        nodoActual = nodoActual.Previo;
                    } while (nodoActual != null);
                    yield break;
                }
            }
        }
        public IEnumerable<Tipo> HaciaAdelante
        {
            get
            {
                if (vacio)
                {
                    yield break;
                }
                else
                {
                    ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                    nodoActual = NodoInicial;
                    do
                    {
                        yield return nodoActual.ObjetoConDatos;
                        nodoActual = nodoActual.Siguiente;
                    } while (nodoActual != null);
                    yield break;
                }
            }
        }

        ~ClaseListaDoble()
        {
            VaciarLista();
        }
    }
}
