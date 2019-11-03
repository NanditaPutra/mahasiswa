using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mahasiswa.Helpers;
using mahasiswa.Models;
using System.Data;

namespace mahasiswa.Services
{
    public class JurusanService
    {
        public List<JurusanModel> GetListJurusan()
        {
            try
            {
                List<JurusanModel> Result = new List<JurusanModel>();
                string Query = @"SELECT * FROM Tb_Jurusan";
                DataTable dt = new DataTable();
                dt = SQLHelpers.GetDataTable(Query);
                foreach (DataRow dr in dt.Rows)
                {
                    Result.Add(
                        new JurusanModel
                        {
                            idJurusan = Convert.ToString(dr["IdJurusan"]),
                            jurusan = Convert.ToString(dr["jurusan"])
                        });
                }
                return Result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<JurusanModel> GetListJurusanById(String id)
        {
            try
            {
                List<JurusanModel> Result = new List<JurusanModel>();
                string Query = @"SELECT * FROM Tb_Jurusan WHERE IdJurusan = '"+id+"'";
                DataTable dt = new DataTable();
                dt = SQLHelpers.GetDataTable(Query);
                foreach (DataRow dr in dt.Rows)
                {
                    Result.Add(
                        new JurusanModel
                        {
                            idJurusan = Convert.ToString(dr["IdJurusan"]),
                            jurusan = Convert.ToString(dr["jurusan"])
                        });
                }
                return Result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int SimpanJurusan(JurusanModel model)
        {
            int hasil = -1;
            try
            {
                string Query = @"INSERT INTO TbJurusan Values('" + model.idJurusan + "','" + model.jurusan + "')";
                hasil = SQLHelpers.ExecQuery(Query);
                return hasil;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int UpdateJurusan(JurusanModel model)
        {
            int hasil = -1;
            try
            {
                string Query = @"UPDATE TbJurusan SET Jurusan = '" + model.jurusan + "' WHERE IdJurusan ='" + model.idJurusan + "' ";
                hasil = SQLHelpers.ExecQuery(Query);
                return hasil;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int DeleteJurusan(string id)
        {
            int hasil = -1;
            try
            {
                string Query = @"DELETE  TbJurusan WHERE IdJurusan= '" + id + "' ";
                hasil = SQLHelpers.ExecQuery(Query);
                return hasil;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool IsDataExist(String id)
        {
            bool hasil = false;
            try
            {
                string Query = @"SELECT * from TbJurusan WHERE IdJurusan = '"+ id +"' ";
                DataTable dt = new DataTable();
                dt = SQLHelpers.GetDataTable(Query);
                if (dt.Rows.Count > 0)
                {
                    hasil = true;
                }
                return hasil;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}