using System;
using System.Data.SqlTypes;
using System.Runtime.Intrinsics.X86;
using WA_MVC.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace WA_MVC.Data
{
    public class DbContext
    {
        private readonly string? strCnn;
        private readonly SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public DbContext()
        {
            strCnn = @"Server=127.0.0.1,1433;Database=test;User Id=dblab2;Password=Fall@f2024;TrustServerCertificate=True;";
            cnn = new SqlConnection(strCnn); // Updated to use System.Data.SqlClient.SqlConnection
            cmd = new SqlCommand(); // Initialize cmd to avoid CS8618
            da = new SqlDataAdapter(); // Initialize da to avoid CS8618
        }
        public DataTable GetAll()
        {
            DataTable dt;
            try
            {
                dt = new DataTable();
                if (cnn.State != ConnectionState.Open)
                    cnn.Open();
                cmd = new SqlCommand("SELECT * FROM books", cnn);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnn.State != ConnectionState.Closed)
                    cnn.Close();
            }
            return dt;
        }
        public int Add(Book book)
        {
            string strCmd = @"INSERT INTO books(bId,bName,catId,bAuthor,bPrice) VALUES({0},'{1}','{2}','{3}',{4})";
            strCmd = string.Format(strCmd, book.Id, book.Name, book.CatId, book.Author, book.Price);
            cmd = new SqlCommand(strCmd, cnn);
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
            int r = cmd.ExecuteNonQuery();
            if (cnn.State != ConnectionState.Closed)
                cnn.Close();
            return r;
        }
    }
}