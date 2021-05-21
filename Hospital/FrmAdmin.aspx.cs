using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FrmCita : System.Web.UI.Page
    {
        ClsReserva objreserva = new ClsReserva();
        ClsCancha objcancha =  new ClsCancha();
        ClsUser objuser = new ClsUser();
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (objreserva.guardar_reserva(TxtCodigo.Text, TxtHora.Text, TxtFecha.Text, txtnom_usuario.Text, txtnom_cancha.Text, Txtvalor_reserva.Text, txtel_usuario.Text, Txtlugar_cancha.Text ))
                {
                 LblMensaje.Text = "Guardado con exito ";
                }
            else
            {
                LblMensaje.Text = "Error al guardar la reservas";
            }
        }

        protected void BtnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea anular esta reserva?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (objreserva.anular_reserva(TxtCodigo_user.Text))
                {
                    LblMensaje.Text = "Reserva anulada";
                    limpiar_campos();
                }
                else
                {
                    LblMensaje.Text = "Error al anular su reserva";
                }
                    
            }
        }
        protected void limpiar_campos()
        {
            TxtCodigo_user.Text = "";
            TxtFecha.Text = "";
            TxtHora.Text = "";
            Txtlugar_cancha.Text = "";
            txtel_usuario.Text = "";
            txtcod_cancha.Text = "";
            Txtvalor_reserva.Text = "";
            txtnom_usuario.Text = "";
            BtnUser.Enabled = false;
        }

        protected void BtnCancha_Click(object sender, EventArgs e)
        {
            if (txtcod_cancha.Text.Trim()=="")
            {
                LblMensaje.Text = "Codigo de la cancha es requerido";
                txtcod_cancha.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                ds = objcancha.consultar_cancha(txtcod_cancha.Text);
                if (ds.Tables[0].Rows.Count==0)
                {
                    LblMensaje.Text = "Cancha no encontrada";
                    txtcod_cancha.Focus();
                } 
                else
                {
                    LblMensaje.Text = "Cancha encontrada";
                    txtcod_cancha.Text = ds.Tables[0].Rows[0]["nom_cancha"].ToString();
                    TxtLugarCancha.Text = ds.Tables[0].Rows[0]["lugar_cancha"].ToString();
                    TxtMaterialCancha.Text = ds.Tables[0].Rows[0]["material_cancha"].ToString();
                    TxtEstadoCancha.Text = ds.Tables[0].Rows[0]["estado_cancha"].ToString();
                }
            }

        }

        protected void BtnActivar_Click(object sender, EventArgs e)
        {
            TxtCodigo_user.Enabled = true;
            TxtFecha.Enabled = true;
            TxtHora.Enabled = true;
            Txtvalor_reserva.Enabled = true;
            Txtlugar_cancha.Enabled = true;
            txtnom_usuario.Enabled = true;
            txtel_usuario.Enabled = true;
            BtnAnular.Enabled = true;
            BtnCancerlar.Enabled = true;
            BtnGuardar.Enabled = true;
            TxtLugarCancha.Text = "";
            TxtCodigo_user.Text = "";
            TxtMaterialCancha.Text = "";
            TxtEstadoCancha.Text = "";
            txtcod_cancha.Text = "";
            LblMensaje.Text = "";
            TxtCodigo.Enabled = true;
            TxtMaterialCancha.Enabled = false;
            TxtLugarCancha.Enabled = false;
            TxtEstadoCancha.Enabled = false;
            txtnom_cancha.Enabled = true;
            TxtCodigo_user.Enabled = false;
            txtcod_cancha.Enabled = false;
            BtnCancha.Enabled = false;
            lbldireccionuser.Text = "";
            lblnomuser.Text = "";
            lblteluser.Text = "";
        
        }

        protected void BtnUser_Click(object sender, EventArgs e)
        {
            if (TxtCodigo_user.Text.Trim()=="")
            {
                LblMensaje.Text = "Digite el nombre del usuario";
                txtnom_usuario.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                ds = objuser.consultar_user(TxtCodigo_user.Text);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "Usuario no encontrado";
                    txtnom_usuario.Focus();
                }
                else
                {
                    LblMensaje.Text = "";
                    lblnomuser.Text = ds.Tables[0].Rows[0]["nom_user"].ToString();
                    lblteluser.Text = ds.Tables[0].Rows[0]["tel_user"].ToString();
                    lbldireccionuser.Text = ds.Tables[0].Rows[0]["direccion_user"].ToString();
                }
            }
        }

        protected void BtnActivarUser_Click(object sender, EventArgs e)
        {
            TxtCodigo_user.Enabled = true;
            TxtCodigo.Enabled = false;
            txtcod_cancha.Enabled = false;
            TxtLugarCancha.Enabled = false;
            TxtMaterialCancha.Enabled = false;
            TxtEstadoCancha.Enabled = false;
            txtnom_cancha.Enabled = false;
            TxtFecha.Enabled = false;
            TxtHora.Enabled = false;
            Txtvalor_reserva.Enabled = false;
            Txtlugar_cancha.Enabled = false;
            txtel_usuario.Enabled = false;
            txtnom_usuario.Enabled = false;
            BtnUser.Enabled = true;
            BtnActivarUser.Enabled = false;
            BtnCancha.Enabled = false;
            TxtCodigo.Text = "";
            TxtCodigo_user.Text = "";
            txtcod_cancha.Text = "";
            txtel_usuario.Text = "";
            TxtEstadoCancha.Text = "";
            TxtFecha.Text = "";
            TxtHora.Text = "";
            TxtLugarCancha.Text = "";
            Txtlugar_cancha.Text = "";
            TxtMaterialCancha.Text = "";
            txtnom_cancha.Text = "";
            txtnom_usuario.Text = "";
            Txtvalor_reserva.Text = "";
            LblMensaje.Text = "";

        }

        protected void BtnCancerlar_Click(object sender, EventArgs e)
        {
            TxtCodigo_user.Enabled = false;
            TxtCodigo.Enabled = false;
            txtcod_cancha.Enabled = true;
            TxtLugarCancha.Enabled = true;
            TxtMaterialCancha.Enabled = true;
            TxtEstadoCancha.Enabled = true;
            txtnom_cancha.Enabled = false;
            TxtFecha.Enabled = false;
            TxtHora.Enabled = false;
            Txtvalor_reserva.Enabled = false;
            Txtlugar_cancha.Enabled = false;
            txtnom_usuario.Enabled = false;
            txtel_usuario.Enabled = false;
            BtnAnular.Enabled = false;
            BtnCancha.Enabled = true;
            BtnActivar.Enabled = true;
            BtnActivarUser.Enabled = true;
            BtnUser.Enabled = false;
            BtnGuardar.Enabled = false;
            BtnCancerlar.Enabled = false;
        }
    }
}