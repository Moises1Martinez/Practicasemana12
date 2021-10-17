using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Practicasemana12
{
    public partial class FrmEdificio : Form
    {
        private string action = "";
        public FrmEdificio()
        {
            InitializeComponent();
        }

        private void FrmEdificio_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        public void fillDataGridView()
        {
            //instancia de la clase libro| Book
            Edificios edificio = new Edificios();

            clearDataGridView();

            dtgEdificio.Columns.Add("Nombre", "Direccion");
            dtgEdificio.Columns.Add("Cantidad de departamentos", "Departamentos rentados");



            //llamado al medoto getAllStudents() de la clase Alumnos
            MySqlDataReader dataReader = edificio.getAllEdificio();

            //leer el resultado y mostrarlo en el datagridview
            while (dataReader.Read())
            {
                dtgEdificio.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5)
                       );
            }
        }

        public void clearDataGridView()
        {
            dtgEdificio.Columns.Clear();
            dtgEdificio.Rows.Clear();
        }

        //deshabilita los controles de formulario
        public void controlsDisable()
        {
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            txtcantidad.Enabled = false;
            txtrentados.Enabled = false;

        }
        //habilitar los controles de formulario
        public void controlsEnable()
        {
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txtcantidad.Enabled = true;
            txtrentados.Enabled = true;

        }
        //limpiar el contenido de los controles
        public void clearControls()
        {
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txtcantidad.Text = "";
            txtrentados.Text = "";
        }

        private void dtgEdificio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            action = "edit";

            controlsEnable();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe rellenar todos los campos necesarios", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus(); //enviamos el enfoque a la caja de texto

            }
            else
            {

                Edificios edificio = new Edificios(); //instancia de la clase Alumnos
                                                      //evaluar la accion



                edificio.nombre = txtnombre.Text;
                edificio.direccion = txtdireccion.Text;
                edificio.cantDepartamentos = txtcantidad.Text;
                edificio.depRentados = txtrentados.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //LLAMAR AL METODO PARA GUARDAR
                    if (edificio.newEditEdificio(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlsEnable();

            txtnombre.Text = dtgEdificio.CurrentRow.Cells[0].Value.ToString();
            txtdireccion.Text = dtgEdificio.CurrentRow.Cells[1].Value.ToString();
            txtcantidad.Text = dtgEdificio.CurrentRow.Cells[2].Value.ToString();
            txtrentados.Text = dtgEdificio.CurrentRow.Cells[3].Value.ToString();
            

            //enviar aaccion
            action = "edit";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Edificios edificio = new Edificios();
                edificio.nombre = Convert.ToString(dtgEdificio.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteBook() de la clase Book
                if (edificio.deleteEdificio())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    fillDataGridView();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
  }
}
