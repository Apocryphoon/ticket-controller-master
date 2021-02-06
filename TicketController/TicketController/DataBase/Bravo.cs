using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketController.DTO;

namespace TicketController.DataBase
{
    public class Bravo
    {
        public List<TableDTO> listarAll()
        {
            string query = "Select * from bravogrc where ds_visible = false";

            DataBase db = new DataBase();
            MySqlDataReader r = db.ExecuteSelect(query, null);

            List<TableDTO> itens = new List<TableDTO>();

            while (r.Read())
            {
                TableDTO t = new TableDTO();
                t.id = r.GetInt32("id");
                t.id_cliente = r.GetString("id_cliente");
                t.nm_cliente = r.GetString("nm_cliente");
                t.ds_status = r.GetString("ds_status");
                t.dt_create = r.GetDateTime("dt_create");
                t.ds_visible = r.GetBoolean("ds_visible");
                t.ds_obs = r.GetString("ds_obs");
                t.nm_responsavel = r.GetString("nm_responsavel");

                itens.Add(t);
            }
            return itens;
        }
        public List<TableDTO> Filtro(string id, string responsavel, string cliente)
        {
            string query = "select * from bravogrc where id_cliente like @id and nm_responsavel like @responsavel and nm_cliente like @cliente and ds_visible = false";

            List<MySqlParameter> param = new List<MySqlParameter>();

            param.Add(new MySqlParameter("id", "%" + id + "%"));
            param.Add(new MySqlParameter("cliente", "%" + cliente + "%"));
            param.Add(new MySqlParameter("responsavel", "%" + responsavel + "%"));

            DataBase db = new DataBase();
            MySqlDataReader r = db.ExecuteSelect(query, param);

            List<TableDTO> c = new List<TableDTO>();
            while (r.Read() == true)
            {
                TableDTO t = new TableDTO();

                t.id = r.GetInt32("id");
                t.id_cliente = r.GetString("id_cliente");
                t.nm_cliente = r.GetString("nm_cliente");
                t.ds_status = r.GetString("ds_status");
                t.dt_create = r.GetDateTime("dt_create");
                t.ds_visible = r.GetBoolean("ds_visible");
                t.ds_obs = r.GetString("ds_obs");
                t.nm_responsavel = r.GetString("nm_responsavel");

                c.Add(t);
            }

            return c;
        }

        public void Salvar(string Cliente, string idCliente, string Responsavel, string Status, DateTime Data, bool Visible, string Obs)
        {
            string query = "insert into bravogrc(id_cliente, nm_cliente, ds_status, dt_create, ds_visible, nm_responsavel, ds_obs) VALUES (@idCliente, @Cliente, @Status, @Data, @Visible, @Responsavel, @Obs)";

            List<MySqlParameter> param = new List<MySqlParameter>();
            param.Add(new MySqlParameter("Responsavel", Responsavel));
            param.Add(new MySqlParameter("Cliente", Cliente));
            param.Add(new MySqlParameter("idCliente", idCliente));
            param.Add(new MySqlParameter("Status", Status));
            param.Add(new MySqlParameter("Data", Data));
            param.Add(new MySqlParameter("Visible", Visible));
            param.Add(new MySqlParameter("Obs", Obs));

            DataBase db = new DataBase();
            db.ExecuteInsert(query, param);
        }

        public void selectRemoved(TableDTO dto)
        {
            string query = "Update bravogrc set" +
                            " id_cliente = @cliente," +
                            " nm_cliente = @nome," +
                            " ds_status = @status," +
                            " dt_create = @create," +
                            " ds_visible = @visible," +
                            " nm_responsavel = @responsavel," +
                            " ds_obs = @obs" +
                            " where id = @id";

            List<MySqlParameter> param = new List<MySqlParameter>();
            param.Add(new MySqlParameter("id", dto.id));
            param.Add(new MySqlParameter("cliente", dto.id_cliente));
            param.Add(new MySqlParameter("nome", dto.nm_cliente));
            param.Add(new MySqlParameter("status", dto.ds_status));
            param.Add(new MySqlParameter("create", dto.dt_create));
            param.Add(new MySqlParameter("visible", dto.ds_visible));
            param.Add(new MySqlParameter("responsavel", dto.nm_responsavel));
            param.Add(new MySqlParameter("obs", dto.ds_obs));

            DataBase db = new DataBase();
            db.ExecuteInsert(query, param);
        }

        public void Editar(string Cliente, string idCliente, string Responsavel, string Status, DateTime Data, bool Visible, int id, string obs)
        {
            string query = "Update bravogrc set" +
                            " id_cliente = @cliente," +
                            " nm_cliente = @nome," +
                            " ds_status = @status," +
                            " dt_create = @create," +
                            " ds_visible = @visible," +
                            " nm_responsavel = @responsavel," +
                            " ds_obs = @obs" +
                            " where id = @id";

            List<MySqlParameter> param = new List<MySqlParameter>();
            param.Add(new MySqlParameter("id", id));
            param.Add(new MySqlParameter("responsavel", Responsavel));
            param.Add(new MySqlParameter("nome", Cliente));
            param.Add(new MySqlParameter("cliente", idCliente));
            param.Add(new MySqlParameter("status", Status));
            param.Add(new MySqlParameter("create", Data));
            param.Add(new MySqlParameter("visible", Visible));
            param.Add(new MySqlParameter("obs", obs));

            DataBase db = new DataBase();
            db.ExecuteInsert(query, param);
        }
    }
}
