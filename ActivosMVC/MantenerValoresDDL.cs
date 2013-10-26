using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ActivosMVC
{
    public class MantenerValoresDDL
    {
       /*
        private void mantenerValoresDDL(DropDownList ddlMunicipio, DropDownList ddlColonias) {
            string municipios = Request.Form[ddlMunicipio.UniqueID];
            string colonias = Request.Form[ddlColonias.UniqueID];

            llenarDropDownList(llenarColonias(int.Parse(municipios)), ddlColonias);
            ddlColonias.Items.FindByValue(colonias).Selected = true;
        }

        [System.Web.Services.WebMethod]
        public static ArrayList llenarColonias(int idMunicipio)
        {
            ArrayList lista = new ArrayList();
            return lista;
        }

        private void llenarDropDownList(ArrayList list, DropDownList ddl)
        {
            ddl.DataSource = list;
            ddl.DataTextField = "Text";
            ddl.DataValueField = "Value";
            ddl.DataBind();
        }
        */

    }
}