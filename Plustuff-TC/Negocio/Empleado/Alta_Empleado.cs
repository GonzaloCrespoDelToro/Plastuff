﻿using C2_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Empleado
{
    public partial class Alta_Empleado : Form
    {
        Modelo.Empleado empleado = new Modelo.Empleado();
        C2_Negocio.Empleado _empleado = new C2_Negocio.Empleado();
        Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Alta_Empleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            empleado.nombre = txtnombre.Text;
            empleado.apellido = txtapellido.Text;
            empleado.dni = txtdni.Text;
            empleado.direccion = txtdirecc.Text;
            empleado.fechanac =Convert.ToDateTime(dtFecha.Text);
            empleado.mail = txtmail.Text;
            empleado.telefono = txtcontacto.Text;

            if (_empleado.Vacio(empleado))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Alta de empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _empleado.Alta_Empleado(empleado);

            //Da de alta en bitacora
            bitacora.Accion = "AltaEmpleado";
            bitacora.Descripcion = $"El usuario {Sesion.Usuario.Nombre} dio de alta al empleado {empleado.nombre} {empleado.apellido}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            DialogResult dialogResult = MessageBox.Show(this, "El empleado se registro con exito", "Alta de empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
