using Activity2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    public class CarDAO : IMobilityDataService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int DeleteCar(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> GetAllCars()
        {
            // Get All Cars
            List<CarModel> foundCars = new List<CarModel>();
            string sqlStatement = "SELECT * FROM dbo.Cars";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                try 
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundCars.Add(new CarModel { Id = (int)reader[0], CarName = (string)reader[1], CarYear = (int)reader[2] });
                    }

                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex);
                }
            }
            return foundCars;

        }

        public CarModel GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertCar(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> SearchCars(string search)
        {
            List<CarModel> foundCars = new List<CarModel>();
            string sqlStatement = "SELECT * FROM dbo.Cars WHERE Car_Name LIKE @Car_Name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Car_Name", '%' + search + '%');
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundCars.Add(new CarModel { Id = (int)reader[0], CarName = (string)reader[1], CarYear = (int)reader[2] });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return foundCars;
        }

        public int UpdateCar(CarModel car)
        {
            throw new NotImplementedException();
        }
    }
}
