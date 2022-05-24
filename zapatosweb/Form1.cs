using entidades;
using logicanegocios.implementacion;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace zapatosweb
{
    public partial class Frmclientes : Form
    {
        private IClientesLN objClientesLN = new ClientesLN();


        public Frmclientes()
        {
            InitializeComponent();
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            cargaclientes();
        }

        public void cargaclientes()
        {
            List<PA_Clientes_MostrarDetalle_Result> lobjRespuesta = new List<PA_Clientes_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objClientesLN.mostrarclientes();
                if (lobjRespuesta.Count > 0)
                {
                    dgvcliente.DataSource = lobjRespuesta;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            PA_Clientes_MostrarDetallexid_Result lobjRespuesta = new PA_Clientes_MostrarDetallexid_Result();
            try
            {
                if (txtidcliente.Text != "")
                {
                    
                    int pid = Convert.ToInt32(txtidcliente.Text);
                    lobjRespuesta = objClientesLN.mostrarclientesxid(pid);
                    txtnomcliente.Text = lobjRespuesta.Nombre;
                    txtdsccliente.Text = lobjRespuesta.telefono;
                    txtapellido1.Text = lobjRespuesta.Ap1;
                    txtapellido2.Text = lobjRespuesta.Ap2;
                    txtemail.Text = lobjRespuesta.email;
                }
                else
                {
                    MessageBox.Show("DEBE INDICAR EL ID DEL CLIENTE.", "ZAPATOS WEB.", MessageBoxButtons.OK);
                }

            }
             catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Clientes pClientes = new Clientes();
            try
            {
                pClientes.Nombre = txtnomcliente.Text;
                pClientes.Ap1 = txtapellido1.Text;
                pClientes.Ap2 = txtapellido2.Text;
                pClientes.telefono = txtdsccliente.Text;
                pClientes.email = txtemail.Text;
               if(objClientesLN.insertarcliente(pClientes))
                {
                    cargaclientes();
                    MessageBox.Show("EL CLIENTE SE AGREGO CORRECTAMENTE.", "ZAPATOS WEB.", MessageBoxButtons.OK);
                    limpiarcamppos();
                }
                else
                {
                    MessageBox.Show("ERROR AL AGREGAR EL CLIENTE.", "ZAPATOS WEB.", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Clientes pClientes = new Clientes();
            try
            {
                int pid = Convert.ToInt32(txtidcliente.Text);
                pClientes.IdCliente = pid;
                pClientes.Nombre = txtnomcliente.Text;
                pClientes.Ap1 = txtapellido1.Text;
                pClientes.Ap2 = txtapellido2.Text;
                pClientes.telefono = txtdsccliente.Text;
                pClientes.email = txtemail.Text;
                if (objClientesLN.actualizarcliente(pClientes))
                {
                    cargaclientes();
                    MessageBox.Show("EL CLIENTE SE ACTUALIZO CORRECTAMENTE.", "ZAPATOS WEB.", MessageBoxButtons.OK);
                    limpiarcamppos();
                }
                else
                {
                    MessageBox.Show("ERROR AL ACTUALIZAR EL CLIENTE.", "ZAPATOS WEB.", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Clientes pClientes = new Clientes();
            try
            {
                int pid = Convert.ToInt32(txtidcliente.Text);
                pClientes.IdCliente = pid;
                if (objClientesLN.eliminarcliente(pClientes))
                {
                    cargaclientes();
                    MessageBox.Show("EL CLIENTE SE ELIMINO CORRECTAMENTE.", "ZAPATOS WEB.", MessageBoxButtons.OK);
                    limpiarcamppos();
                }
                else
                {
                    MessageBox.Show("ERROR AL ELIMINAR EL CLIENTE.", "ZAPATOS WEB.", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void limpiarcamppos()
        {
            txtidcliente.ResetText();
            txtnomcliente.ResetText();
            txtapellido1.ResetText();
            txtapellido2.ResetText();
            txtdsccliente.ResetText();
            txtemail.ResetText();
        }
    }
}
