using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionForms
{
    public class EmpresaCurtidoraDePieles: IComparable<EmpresaCurtidoraDePieles>, IEquatable<EmpresaCurtidoraDePieles>, IEnumerable<EmpresaCurtidoraDePieles>, IEnumerator<EmpresaCurtidoraDePieles>
    {  
        public EmpresaCurtidoraDePieles()
        {
            
        }
        
        

        public bool Equals(EmpresaCurtidoraDePieles obj)
        {
            if ((obj.ID == this.ID) )//|| !this.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(EmpresaCurtidoraDePieles other)
        {
            if(this.ID<other.ID)
            {
                return -1;
            }else
            {
                return 1;
            }
        }

        public IEnumerator<EmpresaCurtidoraDePieles> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
            //throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        private int _dblSueldoXAño;

        public int Sueldo
        {
            get { return _dblSueldoXAño; }
            set { _dblSueldoXAño = value; }
        }
        private string _strNombreEmpleado;

        public string Nombre
        {
            get { return _strNombreEmpleado; }
            set { _strNombreEmpleado = value; }
        }
        private char _chrInicialEmpleado;

        public char Inicial
        {
            get { return _chrInicialEmpleado; }
            set { _chrInicialEmpleado = value; }
        }
        private DateTime _dtmFechaIngreso;

        public DateTime Fecha
        {
            get { return _dtmFechaIngreso; }
            set { _dtmFechaIngreso = value; }
        }
        private bool _blnSeguroMedico;

        public bool Seguro
        {
            get { return _blnSeguroMedico; }
            set { _blnSeguroMedico = value; }
        }
        private string _DireccionPath;

        public string Direccion
        {
            get { return _DireccionPath; }
            set { _DireccionPath = value; }
        }
        private string _intPuesto;

        public string Puesto
        {
            get { return _intPuesto; }
            set { _intPuesto = value; }
        }
        private int _intCantidadProductos;

        public int Productos
        {
            get { return _intCantidadProductos; }
            set { _intCantidadProductos = value; }
        }
        private string _strGenero;

        public string Genero
        {
            get { return _strGenero; }
            set { _strGenero = value; }
        }

        public EmpresaCurtidoraDePieles Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();
        ~EmpresaCurtidoraDePieles()
        {

        }
        public override string ToString()
        {
            string x;
            if(this.Seguro)
            {
                x = "Si";
            }else
            {
                x = "No";
            }
            return $"Nombre: {this.Nombre} \nNumero ID: {this.ID}\nSueldo: {this.Sueldo}\nLetra inicial: {this.Inicial}\nFecha de ingreso a la empresa: {this.Fecha}\nGenero: {this.Genero}\nProductos hechos al mes {this.Productos}\nPuesto del trabajador: {this.Puesto}\n¿Tiene seguro?: {x}";     
        }
    }
}
