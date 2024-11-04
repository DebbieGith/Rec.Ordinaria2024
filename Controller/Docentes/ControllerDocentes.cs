using Refuerzo2024.Model.DAO;
using Refuerzo2024.View.Docentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Refuerzo2024.Controller.Docentes
{
    internal class ControllerDocentes
    {
        ViewDocentes objDocentes;

        public ControllerDocentes(ViewDocentes objDocentes)
        {
            this.objDocentes = objDocentes;
            objDocentes.Load += new EventHandler(CargaInicial);
            objDocentes.dgvDocentes.CellClick += new DataGridViewCellEventHandler(seleccionarDato);
            objDocentes.btnAgregar.Click += new EventHandler(AgregarDocente);
            objDocentes.btnActualizar.Click += new EventHandler(ActualizarDocente);
            objDocentes.btnEliminar.Click += new EventHandler(EliminarDocente);
            objDocentes.btnBuscarDocente.Click += new EventHandler(BuscarDocente);
        }

        public void CargaInicial (object sender, EventArgs e) 
        {
            LlenarDataGridView();
        }

        private void LlenarDataGridView () 
        { 
            DAODocentes obj = new DAODocentes();
            DataSet ds = obj.ObtenerDocente();
            //Llenamos el el DataGridView
            objDocentes.dgvDocentes.DataSource = ds.Tables["Docentes"];
        }

        public void seleccionarDato (object sender, EventArgs e)
        {
            int pos = objDocentes.dgvDocentes.CurrentRow.Index;
            //Enviar los datos del Data a los controles
            objDocentes.txtIDDocente.Text = objDocentes.dgvDocentes[0,pos].Value.ToString();
            objDocentes.txtNombres.Text = objDocentes.dgvDocentes[1, pos].Value.ToString();
            objDocentes.txtApellidos.Text = objDocentes.dgvDocentes[2, pos].Value.ToString();
            objDocentes.txtDocumento.Text = objDocentes.dgvDocentes[3, pos].Value.ToString();

        }

        public void AgregarDocente (object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(objDocentes.txtNombres.Text.Trim())||
                String.IsNullOrEmpty(objDocentes.txtApellidos.Text.Trim())||
                String.IsNullOrEmpty(objDocentes.txtDocumento.Text.Trim())
                ))
             
            {
                DAODocentes data = new DAODocentes();
                //Guardar en los atributos del DTO todos los valores contenidos en los componentes del formulario
                data.NombreDocente = objDocentes.txtNombres.Text.Trim();
                data.ApellidoDocente = objDocentes.txtApellidos.Text.Trim();
                data.Dui = objDocentes.txtDocumento.Text.Trim();
                //Se invoca al metodo RegistrarEstudiante y se verifica si su retorno es TRUE, de ser así significa que los datos pudieron ser registrados correctamente, de lo contrario, no se pudo registrar los valores.
                if (data.AgregarDocente() == true)
                {
                    MessageBox.Show("Datos registrados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridView();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los datos", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo agregar un Docente", "Hay espacios vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ActualizarDocente(object sender, EventArgs e)
        {
            DAODocentes data = new DAODocentes();
            //Guardar en los atributos del DTO todos los valores contenidos en los componentes del formulario
            data.IdDocente = int.Parse(objDocentes.txtIDDocente.Text.Trim().ToString());
            data.NombreDocente = objDocentes.txtNombres.Text.Trim();
            data.ApellidoDocente = objDocentes.txtApellidos.Text.Trim();
            data.Dui = objDocentes.txtDocumento.Text.Trim();

            if (data.ActualizarDocente() == true)
            {
                MessageBox.Show("Los datos fueron actualizados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridView();
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarDocente (object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(objDocentes.txtIDDocente.Text.Trim()))
            {
                MessageBox.Show("Seleccione un registro", "Seleccione un valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DAODocentes data = new DAODocentes();
                data.IdDocente = int.Parse(objDocentes.txtIDDocente.Text);
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (data.EliminarDocente() == true)
                    {
                        MessageBox.Show("El dato fue eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser eliminado", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void BuscarDocente (object sender, EventArgs e)
        {
            DAODocentes data = new DAODocentes();
            DataSet ds = data.BuscarDocente(objDocentes.txtBuscarDocente.Text.Trim());
            objDocentes.dgvDocentes.DataSource = ds.Tables["Docentes"];
        }
    }
}
