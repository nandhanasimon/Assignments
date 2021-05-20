﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyLocationRepository : BaseAdo, IDataRepository<CompanyLocationPoco>
    {
        public void Add(params CompanyLocationPoco[] items)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            foreach (CompanyLocationPoco item in items)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"INSERT INTO [dbo].[Company_Locations]
                                       ([Id]
                                       ,[Company]
                                       ,[Country_Code]
                                       ,[State_Province_Code]
                                       ,[Street_Address]
                                       ,[City_Town]
                                       ,[Zip_Postal_Code])
                                 VALUES
                                        (@Id
                                        ,@Company
                                        ,@CountryCode
                                        ,@StateProvinceCode
                                        ,@StreetAddress
                                        ,@CityTown
                                        ,@ZipPostalCode)";
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Company", item.Company);
                cmd.Parameters.AddWithValue("@CountryCode", item.CountryCode);
                cmd.Parameters.AddWithValue("@StateProvinceCode", item.Province);
                cmd.Parameters.AddWithValue("@StreetAddress", item.Street);
                cmd.Parameters.AddWithValue("@CityTown", item.City);
                cmd.Parameters.AddWithValue("@ZipPostalCode", item.PostalCode);

                connection.Open();
                int rowEffected = cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyLocationPoco> GetAll(params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT *
                              FROM [dbo].[Company_Locations]";

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            CompanyLocationPoco[] pocos = new CompanyLocationPoco[1000];
            int counter = 0;
            while (rdr.Read())
            {
                CompanyLocationPoco poco = new CompanyLocationPoco();
                poco.Id = rdr.GetGuid(0);
                poco.Company = rdr.GetGuid(1);
                poco.CountryCode = rdr.GetString(2);
                poco.Province = rdr.GetString(3);
                poco.Street = rdr.GetString(4);
                if (!rdr.IsDBNull(5))
                {
                    poco.City = rdr.GetString(5);
                }
                if (!rdr.IsDBNull(6))
                {
                    poco.PostalCode = rdr.GetString(6);
                }
                poco.TimeStamp = (byte[])rdr[7];

                pocos[counter] = poco;
                counter++;
            }
            conn.Close();
            return pocos.Where(p => p != null).ToList();
        }

        public IList<CompanyLocationPoco> GetList(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyLocationPoco GetSingle(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyLocationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyLocationPoco[] items)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (CompanyLocationPoco item in items)
            {
                cmd.CommandText = @"DELETE FROM [dbo].[Company_Locations]
                                        WHERE [Id]= @Id";

                cmd.Parameters.AddWithValue("@Id", item.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Update(params CompanyLocationPoco[] items)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            foreach (CompanyLocationPoco item in items)
            {
                cmd.CommandText = @"UPDATE [dbo].[Company_Locations]
                                       SET [Id] = @Id
                                          ,[Company] = @Company
                                          ,[Country_Code] = @CountryCode
                                          ,[State_Province_Code] = @StateProvinceCode
                                          ,[Street_Address] = @StreetAddress
                                          ,[City_Town] = @CityTown
                                          ,[Zip_Postal_Code] = @ZipPostalCode
                                           WHERE [Id]= @Id";
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Company", item.Company);
                cmd.Parameters.AddWithValue("@CountryCode", item.CountryCode);
                cmd.Parameters.AddWithValue("@StateProvinceCode", item.Province);
                cmd.Parameters.AddWithValue("@StreetAddress", item.Street);
                cmd.Parameters.AddWithValue("@CityTown", item.City);
                cmd.Parameters.AddWithValue("@ZipPostalCode", item.PostalCode);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
    }
}
