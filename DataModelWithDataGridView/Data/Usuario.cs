using DataModelWithDataGridView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelWithDataGridView.Data
{
    public class Usuario
    {
        List<Model.UsuarioModel> lista = new List<Model.UsuarioModel>();

        public void Guardar(UsuarioModel model)
        {
            lista.Add(model);
        }

        public List<UsuarioModel> consultar()
        {
            return lista; 
        }
    }
}
