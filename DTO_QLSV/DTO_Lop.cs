﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_Lop
    {
        private string _Lop_MaLop;
        private string _Lop_TenLop;
        private bool _Lop_LoaiLop;
        private string _Lop_NienKhoa;
        private DateTime _Lop_NgayBatDau;
        private DateTime _Lop_NgayKetThuc;
        private string _Lop_MaMonHoc;
        private string _Lop_MaGiaoVien;

        private string CotTimKiem;
        private string DKTim;
        private int cotGoiY;
        private TextBox txtGoiy;
        private ComboBox _cmbMaGiaoVien;
        private ComboBox _cmbMaMonHoc;

        public TextBox TXTGOIY
        {
            get { return txtGoiy; }
            set { txtGoiy = value; }
        }

        public int COTGOIY
        {
            get { return cotGoiY; }
            set { cotGoiY = value; }
        }


        public string COTIMKIEM
        {
            get { return CotTimKiem; }
            set { CotTimKiem = value; }
        }


        public string DKTIM
        {
            get { return DKTim; }
            set { DKTim = value; }
        }
        public ComboBox cmbMaMonHoc
        {
            get { return _cmbMaMonHoc; }
            set { _cmbMaMonHoc = value; }
        }


        public ComboBox cmbMaGiaoVien
        {
            get { return _cmbMaGiaoVien; }
            set { _cmbMaGiaoVien = value; }
        }

        public string Lop_MaLop
        {
            get
            {
                return _Lop_MaLop;
            }
            set
            {
                _Lop_MaLop = value;
            }
        }
        public string Lop_TenLop
        {
            get
            {
                return _Lop_TenLop;
            } set
            {
                _Lop_TenLop = value;
            }
        }
        public bool Lop_LoaiLop
        {
            get
            {
                return _Lop_LoaiLop;
            } 
            set
            {
                _Lop_LoaiLop = value;
            }
        }
        public string Lop_NienKhoa
        {
            get
            {
                return _Lop_NienKhoa;
            }
            set
            {
                _Lop_NienKhoa = value;
            }
        }
        public DateTime Lop_NgayBatDau
        {
            get
            {
                return _Lop_NgayBatDau;
            }
            set
            {
                _Lop_NgayBatDau = value;
            }
        }
        public DateTime Lop_NgayKetThuc
        {
            get
            {
                return _Lop_NgayKetThuc;
            }
            set
            {
                _Lop_NgayKetThuc = value;
            }
        }
        public string Lop_MaMonHoc
        {
            get
            {
                return _Lop_MaMonHoc;
            }
            set
            {
                _Lop_MaMonHoc = value;
            }
        }
        public string Lop_MaGiaoVien
        {
            get
            {
                return _Lop_MaGiaoVien;
            }
            set
            {
                _Lop_MaGiaoVien = value;
            }
        }
        public DTO_Lop()
        {

        }
        public DTO_Lop(string MaLop, string TenLop, bool LoaiLop, string NienKhoa, DateTime NgayBatDau, DateTime NgayKetThuc, string MaMonHoc, string MaGiaoVien,string mamonhoc,string magiaovien)
        {
            this._Lop_MaLop = MaLop;
            this._Lop_TenLop = TenLop;
            this._Lop_LoaiLop = LoaiLop;
            this._Lop_NienKhoa = NienKhoa;
            this._Lop_NgayBatDau = NgayBatDau;
            this._Lop_NgayKetThuc = NgayKetThuc;
            this._Lop_MaMonHoc = MaMonHoc;
            this._Lop_MaGiaoVien = MaGiaoVien;
        }
    }


}
