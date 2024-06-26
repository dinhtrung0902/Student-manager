﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Khoa
    {
        private string _Khoa_MaKhoa;
        private string _Khoa_TenKhoa;
        private string _Khoa_GhiChu;
        private string _Khoa_Username;


        public string Khoa_MaKhoa
        {
            get { return _Khoa_MaKhoa; }
            set { _Khoa_MaKhoa = value; }
        }
        public string Khoa_TenKhoa
        {
            get { return _Khoa_TenKhoa; }
            set { _Khoa_TenKhoa = value; }
        }
        public string Khoa_GhiChu
        {
            get { return _Khoa_GhiChu; }
            set { _Khoa_GhiChu = value; }
        }
        public string Khoa_Username
        {
            get { return _Khoa_Username; }
            set { _Khoa_Username = value; }
        }
        public DTO_Khoa()
        {

        }
        public DTO_Khoa(string MaKhoa,string TenKhoa, string GhiChu,string Username)
        {
            this._Khoa_MaKhoa = MaKhoa;
            this._Khoa_TenKhoa = TenKhoa;
            this._Khoa_GhiChu = GhiChu;
            this._Khoa_Username = Username;
        }
    }
}
