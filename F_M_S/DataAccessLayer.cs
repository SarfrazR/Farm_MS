using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace F_M_S
{
    internal class DataAccessLayer
    {
        public static SqlConnection GetConnection()
        {
            string strConnection = @"Data Source = DESKTOP-58TMAQD ; Initial Catalog = FMS ; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(strConnection);
            try
            {
                connection.Open();
                // MessageBox.Show("Succesfull");
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection Failure!");
            }
            return connection;
        }
        public static SqlDataReader GetEmployeID()
        {
            string qry = "select ID from Employe;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static SqlDataReader GetAnimalID()
        {
            string qry = "select AnimalID from Animal;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetOrderID()
        {
            string qry = "select OredrID from Product;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static SqlDataReader GetTreatmentID()
        {
            string qry = "select treatmentID from Treatment;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static void AddEmploye(string ID, string Name, string JobT ,string cnic, string contact, string Address ,string email)
        {
            string qry = "insert into Employe values (@ID,@Name,@JobT,@cnic,@contact,@Address,@email);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@JobT", JobT);
            command.Parameters.AddWithValue("@cnic", cnic);
            command.Parameters.AddWithValue("@contact", contact);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();
        }

        public static void AddProduct(string OredrID, string Ptype, int Pcost, int Pamount, string Collector, int TCharges)
        {
            string qry = "insert into Product values (@OredrID,@ProductType,@ProductCost,@ProductAmount,@TotalPrice,@Collector,@TransportCharges);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@OredrID", OredrID);
            command.Parameters.AddWithValue("@ProductType", Ptype);
            command.Parameters.AddWithValue("@ProductCost", Pcost);
            command.Parameters.AddWithValue("@ProductAmount", Pamount);
            command.Parameters.AddWithValue("@TotalPrice", Pcost + Pamount + TCharges);
            command.Parameters.AddWithValue("@Collector", Collector);
            command.Parameters.AddWithValue("@TransportCharges", TCharges);
            command.ExecuteNonQuery();
        }

        public static void AddAccounts(string Acc, string Oid, int Total, string Tid, int TCost)
        {
            string qry = "insert into Accounts values (@AccountNo,@OrderID,@Total,@TreatmentID,@TreatmentCost,@Gain);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@OrderID", Oid);
            command.Parameters.AddWithValue("@AccountNo", Acc);
            command.Parameters.AddWithValue("@Total", Total);
            command.Parameters.AddWithValue("@TreatmentID",Tid);
            command.Parameters.AddWithValue("@TreatmentCost",TCost);
            command.Parameters.AddWithValue("@Gain", Total - TCost);
            command.ExecuteNonQuery();
        }

        public static void UpdateAccounts(string Acc, string Oid, int Total, string Tid, int TCost)
        {
            string qry = "Update Accounts set OrderID = @OrderID,Total=@Total,TreatmentID=@TreatmentID,TreatmentCost=@TreatmentCost,Gain=@Gain Where AccountNo ='"+Acc+"';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@OrderID", Oid);
            command.Parameters.AddWithValue("@Total", Total);
            command.Parameters.AddWithValue("@TreatmentID", Tid);
            command.Parameters.AddWithValue("@TreatmentCost", TCost);
            command.Parameters.AddWithValue("@Gain", Total-TCost);
            command.ExecuteNonQuery();
        }



        public static void UpdateProduct(string OredrID, string Ptype, int Pcost, int Pamount, string Collector, int TCharges)
        {
            string qry = "Update Product Set ProductType=@ProductType,ProductCost=@ProductCost,ProductAmount=@ProductAmount,TotalPrice=@TotalPrice,Collector=@Collector,TransportCharges=@TransportCharges where OredrID = '"+OredrID+"';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@ProductType", Ptype);
            command.Parameters.AddWithValue("@ProductCost", Pcost);
            command.Parameters.AddWithValue("@ProductAmount", Pamount);
            command.Parameters.AddWithValue("@TotalPrice", (Pcost*Pamount) + TCharges);
            command.Parameters.AddWithValue("@Collector", Collector);
            command.Parameters.AddWithValue("@TransportCharges", TCharges);
            command.ExecuteNonQuery();
        }

        public static void AddTreatment(string treatmentID, string treatmentDate, string MedName, string  MedType, string MedExpiry, string EmpID, int treatmentCost, string AnimalID)
        {
            string qry = "insert into Treatment values (@treatmentID,@treatmentDate,@MedName,@MedType,@MedExpiry,@EmpID,@treatmentCost,@AnimalID);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@treatmentID", treatmentID);
            command.Parameters.AddWithValue("@treatmentDate", treatmentDate);
            command.Parameters.AddWithValue("@MedName", MedName);
            command.Parameters.AddWithValue("@MedType", MedType);
            command.Parameters.AddWithValue("@MedExpiry", MedExpiry);
            command.Parameters.AddWithValue("@EmpID", EmpID);
            command.Parameters.AddWithValue("@treatmentCost", treatmentCost);
            command.Parameters.AddWithValue("@AnimalID", AnimalID);
            command.ExecuteNonQuery();
        }

        public static void UpdateTreatment(string treatmentID, string treatmentDate, string MedName, string MedType, string MedExpiry, string EmpID, int treatmentCost, string AnimalID)
        {
            string qry = "Update Treatment Set treatmentDate = @treatmentDate,MedName = @MedName,MedType = @MedType,MedExpiry = @MedExpiry,EmpID = @EmpID,treatmentCost = @treatmentCost,AnimalID = @AnimalID where treatmentID = '" +treatmentID+"';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@treatmentDate", treatmentDate);
            command.Parameters.AddWithValue("@MedName", MedName);
            command.Parameters.AddWithValue("@MedType", MedType);
            command.Parameters.AddWithValue("@MedExpiry", MedExpiry);
            command.Parameters.AddWithValue("@EmpID", EmpID);
            command.Parameters.AddWithValue("@treatmentCost", treatmentCost);
            command.Parameters.AddWithValue("@AnimalID", AnimalID);
            command.ExecuteNonQuery();
        }

        public static void AddAnimal(string AnimalID, string AnimalType, string Feed, int Production)
        {
            string qry = "insert into Animal values (@AnimalID,@AnimalType,@Feed,@Production);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@AnimalID", AnimalID);
            command.Parameters.AddWithValue("@AnimalType", AnimalType);
            command.Parameters.AddWithValue("@Feed", Feed);
            command.Parameters.AddWithValue("@Production", Production);
            command.ExecuteNonQuery();
        }

        public static void UpdateAnimal(string AnimalID, string AnimalType, string Feed, int Production)
        {
            string qry = "Update Animal Set AnimalType=@AnimalType , Feed=@Feed , Production=@Production Where AnimalID=@AnimalID ;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@AnimalID", AnimalID);
            command.Parameters.AddWithValue("@AnimalType", AnimalType);
            command.Parameters.AddWithValue("@Feed", Feed);
            command.Parameters.AddWithValue("@Production", Production);
            command.ExecuteNonQuery();
        }
        public static void UpdateEmploye(string ID, string Name, string JobT, string cnic, string contact, string Address ,string email)
        {
            string qry = "Update Employe set Name=@Name,JobT=@JobT,cnic=@cnic,contact=@contact,Address=@Address,email=@email where ID = @ID ;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@JobT", JobT);
            command.Parameters.AddWithValue("@cnic", cnic);
            command.Parameters.AddWithValue("@contact", contact);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();
        }
        public static void DeleteEmploye(string ID)
        {
            string qry = "delete from Employe where ID = '" + ID + "';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }
        public static void DeleteAccounts(string AccNo)
        {
            string qry = "delete from Accounts where AccountNo = '" + AccNo + "';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }
        public static void DeleteProduct(string OrderID)
        {
            string qry = "delete from Product where OredrID = '" + OrderID + "';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }
        public static void DeleteTrearment(string treatmentID)
        {
            string qry = "delete from Treatment where treatmentID = '" + treatmentID + "';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }
        public static void DeleteAnimal(string AnimalID)
        {
            string qry = "delete from Animal where AnimalID = '" + AnimalID + "';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }
        
    }
}
