using DatosCarrera.dominio.auxiliares;
using DatosCarrera.dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TecnicaturasPresentacion.Cliente
{
    public static class Combo
    {
        public static async void CargarComboProvincia(ComboBox cbo, string url)
        {
            var response = await SingletonHttpClient.ObtenerInstancia().GetAsync(url);
            var objeto = JsonConvert.DeserializeObject<List<Provincia>>(response);
            cbo.DataSource = objeto;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "Id";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static async void CargarComboCiudad(ComboBox cbo, string url)
        {
            var response = await SingletonHttpClient.ObtenerInstancia().GetAsync(url);
            var objeto = JsonConvert.DeserializeObject<List<Ciudad>>(response);
            cbo.DataSource = objeto;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "Id";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static async void CargarComboBarrio(ComboBox cbo, string url)
        {
            var response = await SingletonHttpClient.ObtenerInstancia().GetAsync(url);
            var objeto = JsonConvert.DeserializeObject<List<Barrio>>(response);
            cbo.DataSource = objeto;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "Id";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static async void CargarComboEstadosCiviles(ComboBox cbo, string url)
        {
            var response = await SingletonHttpClient.ObtenerInstancia().GetAsync(url);
            var objeto = JsonConvert.DeserializeObject<List<EstadosCiviles>>(response);
            cbo.DataSource = objeto;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "Id";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static async void CargarComboTecnicaturas(ComboBox cbo, string url)
        {
            var response = await SingletonHttpClient.ObtenerInstancia().GetAsync(url);
            var objeto = JsonConvert.DeserializeObject<List<Carrera>>(response);
            cbo.DataSource = objeto;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "Id";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static async void CargarComboCurso(ComboBox cbo, string url)
        {
            var response = await SingletonHttpClient.ObtenerInstancia().GetAsync(url);
            var objeto = JsonConvert.DeserializeObject<List<Curso>>(response);
            cbo.DataSource = objeto;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "Id";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}

