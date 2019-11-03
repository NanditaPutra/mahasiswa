using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using mahasiswa.Helpers;
using mahasiswa.Models;

namespace mahasiswa.Services
{
    public class mahasiswaservice
    {
        public List<mahasiswamodel> GetListMahasiswa()

        {
            try
            {
                List<mahasiswamodel> Result = new List<mahasiswamodel>();
                string Query = @"SELECT
                            m.NPM,
                            m.Nama,
                            m.JK,
                            j.Jurusan,
                            m.Alamat,
                            Convert(varchar,m.TglLahir,101) TglLahir,
                            m.Email
                          FROM TbMahasiswa m LEFT JOIN
                          Tbjurusan J on m.IdJurusan = J.IdJurusan";
                DataTable dt = new DataTable();
                dt = SQLHelpers.GetDataTable(Query);

                foreach (DataRow dr in dt.Rows)
                {
                    Result.Add(
                        new mahasiswamodel
                        {
                            NPM = Convert.ToString(dr["NPM"]),
                            Nama = Convert.ToString(dr["Nama"]),
                            JK = Convert.ToString(dr["JK"]),
                            Jurusan = Convert.ToString(dr["Jurusan"]),
                            Alamat = Convert.ToString(dr["Alamat"]),
                            TglLahir = Convert.ToString(dr["TglLahir"]),
                            Email = Convert.ToString(dr["Email"])
                        });
                }
                return Result;



            }
            catch (Exception)
            {

                throw;
            }

        }
    }

}
