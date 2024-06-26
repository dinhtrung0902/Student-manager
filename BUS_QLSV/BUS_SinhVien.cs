﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLSV;
using DTO_QLSV;
using System.Windows.Forms;

namespace BUS_QLSV
{
    public class BUS_SinhVien
    {
        DAL_SinhVien DalSinhVien = new DAL_SinhVien();
        DTO_SinhVien DtoSinhVien = new DTO_SinhVien();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        public void ThemSinhVien(string masv,string hoten,string quequan,DateTime ngaysinh,string noisinh,string hinh,string gioitinh,string malop,string manganh)
        {
            int tuoi=DateTime.Now.Year;

            if ((tuoi - ngaysinh.Year >= 18) && (tuoi - ngaysinh.Year < 24))
            {
                DalSinhVien.ThemSinhVien(masv, hoten, quequan, ngaysinh, noisinh, hinh, gioitinh,malop, manganh);
            }
            else
            {
                MessageBox.Show("Sinh viên phải >=17 tuổi ");
            }
        }

        public void CapNhatSinhVien(string masv, string hoten, string quequan, DateTime ngaysinh, string noisinh, string hinh, string gioitinh,string malop, string manganh)
        {
            int tuoi = DateTime.Now.Year;
            if ((tuoi - ngaysinh.Year >= 18) && (tuoi - ngaysinh.Year < 24))
            {
                DalSinhVien.CapNhatSinhVien(masv, hoten, quequan, ngaysinh, noisinh, hinh, gioitinh,malop, manganh);
            }
            else
            {
                MessageBox.Show("Sinh viên phải >=17 tuổi ");
            }
        }

        public void XoaSinhVien(string masv)
        {
            DalSinhVien.XoaSinhVien(masv);
        }

        public string TaoMaSinhVien()
        {
            string msv = DalSinhVien.TaoMaSinhVien();
            return msv;
        }
        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = DalSinhVien.LoadDL();
            return dt;
        }
        public void TextBoxAutoComplete(TextBox TXT,string table,int column)
        {
            
            BUS_xuly.TextBox_AutoComplete(TXT, table, column);
        }
        public DataTable TimKiemSV(string columnName,string dktim)
        {
            DataTable dt = new DataTable();
            dt = DalSinhVien.TimKiemSV(columnName, dktim);
            return dt;
        }
        public DataTable ReportSV(string field1,string DKtim1,string field2,string DKtim2)
        {
            DataTable dt = new DataTable();
            dt = DalSinhVien.ReportSinhVien(field1, DKtim1, field2, DKtim2);
            return dt;
        }
        public void LayDLVaoComboboxMaNganh(ComboBox CMB)
        {
            DalSinhVien.LayMaNganhVaoComBoboxMaNganh(CMB);
        }
        public void LayDLVaoComboboxMaLop(ComboBox CMB)
        {
            DalSinhVien.LayMaNganhVaoComBoboxMaLop(CMB);
        }
    }
}
