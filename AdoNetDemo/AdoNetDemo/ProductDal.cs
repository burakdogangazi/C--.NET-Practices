﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoNetDemo
{
    class ProductDal//data accsess layer
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Etrade;integrated security=true");
        public List<Product> GetAll()
        {
            // uzaktaki veri tabanına bağlanmak için security = false uid=engin;password=12345 yazarsın 
            // @ demek burdaki yazdıklarım ıstring kabul et demek


            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);//bağlantıya göndericez

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())//readerı kayıtları okuyabildğin sürece oku
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    CategoryId = Convert.ToInt32(reader["CategoryId"])
                };
                products.Add(product);
            }

            reader.Close();

            _connection.Close();

            return products;


        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();// bağlantı açıkken
            }
        }

        public DataTable GetAll2()
        {
            // uzaktaki veri tabanına bağlanmak için security = false uid=engin;password=12345 yazarsın 
            // @ demek burdaki yazdıklarım ıstring kabul et demek

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products",_connection);//bağlantıya göndericez

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            
            dataTable.Load(reader);

            reader.Close();

            _connection.Close();

            return dataTable;


        }

        public void Add(Product product)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount,@categoryId)", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@categoryId", product.CategoryId);
            command.ExecuteNonQuery();// etkilenen kayıt sayısını döndürür

            _connection.Close();
        }

        public void Update(Product product)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Products set Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount, CategoryId = @categoryId where Id = @id", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@categoryId", product.CategoryId);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();// etkilenen kayıt sayısını döndürür

            _connection.Close();
        }

        public void Delete(int id)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Prdocuts where Id= @id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();// etkilenen kayıt sayısını döndürür

            _connection.Close();
        }
    }
}
