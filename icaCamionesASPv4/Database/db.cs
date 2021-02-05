using icaCamionesASPv4.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace icaCamionesASPv4.Database
{
    public class db
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DESACDCEntitiesP"].ConnectionString);

        // MÉTODOS USUARIOS //////////////////////////////////////////////////////////////////////////////////////
        public void Add_Usuario(tb_Usuarios usu)
        {
            SqlCommand com = new SqlCommand("Ps_sg_Usuarios_Create", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", usu.COD_USU);
            com.Parameters.AddWithValue("@NOM_USU", usu.NOM_USU);
            com.Parameters.AddWithValue("@NIC_USU", usu.NIC_USU);
            com.Parameters.AddWithValue("@PWD_USU", usu.PWD_USU);
            com.Parameters.AddWithValue("@PER_USU", usu.PER_USU);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Edit_Usuario(tb_Usuarios usu)
        {
            SqlCommand com = new SqlCommand("Ps_sg_Usuarios_Update", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", usu.COD_USU);
            com.Parameters.AddWithValue("@NOM_USU", usu.NOM_USU);
            com.Parameters.AddWithValue("@NIC_USU", usu.NIC_USU);
            com.Parameters.AddWithValue("@PWD_USU", usu.PWD_USU);
            com.Parameters.AddWithValue("@PER_USU", usu.PER_USU);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataSet Usuario_byId(int id)
        {
            SqlCommand com = new SqlCommand("Ps_sg_Usuarios_byId", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet All_Usuario()
        {
            SqlCommand com = new SqlCommand("Ps_sg_Usuarios_All", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void Delete_Usuario(int id)
        {
            SqlCommand com = new SqlCommand("Ps_sg_Usuarios_Delete", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }


        // MÉTODOS ROLES //////////////////////////////////////////////////////////////////////////////////////
        public void Add_Rol(se_Roles rol)
        {
            SqlCommand com = new SqlCommand("Ps_se_Roles_Create", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", rol.COD_USU);
            com.Parameters.AddWithValue("@NOM_ROL", rol.NOM_ROL);
            com.Parameters.AddWithValue("@DES_ROL", rol.DES_ROL);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Edit_Rol(se_Roles rol)
        {
            SqlCommand com = new SqlCommand("Ps_se_Roles_Update", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", rol.COD_USU);
            com.Parameters.AddWithValue("@NOM_ROL", rol.NOM_ROL);
            com.Parameters.AddWithValue("@DES_ROL", rol.DES_ROL);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataSet Rol_byUsu(int id)
        {
            SqlCommand com = new SqlCommand("Ps_se_Roles_byUsu", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void Delete_Rol(int id)
        {
            SqlCommand com = new SqlCommand("Ps_se_Roles_Delete", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@COD_USU", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

    }
}