﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_Diem
    {
        private string _Diem_MaMonHoc;
        private string _Diem_MaSinhVien;
        private float _Diem_SoDiem;
        private int _Diem_LanThi;

        private ListBox lb;
        private string _MSSV;
        private TextBox txtTimMsv;
        public TextBox txtTIMMSV
        {
            get { return txtTimMsv; }
            set { txtTimMsv = value; }
        }
        public string MSSV
        {
            get { return _MSSV; }
            set { _MSSV = value; }
        }

        public ListBox LISTBOX
        {
            get { return lb; }
            set { lb = value; }
        }

        public string Diem_MaMonHoc
        {
            get { return _Diem_MaMonHoc; }
            set { _Diem_MaMonHoc = value; }
        }
        public string Diem_MaSinhVien
        {
            get { return _Diem_MaSinhVien; }
            set { _Diem_MaSinhVien = value; }
        }
        public float Diem_SoDiem
        {
            get { return _Diem_SoDiem; }
            set { _Diem_SoDiem = value; }
        }
        public int Diem_LanThi
        {
            get { return _Diem_LanThi; }
            set { _Diem_LanThi = value; }
        }
        public DTO_Diem() {  }
        public DTO_Diem(string MaMonHoc, string MaSinhVien, float SoDiem, int LanThi)
        {
            this._Diem_MaMonHoc = MaMonHoc;
            this._Diem_MaSinhVien = MaSinhVien;
            this._Diem_SoDiem = SoDiem;
            this._Diem_LanThi = LanThi;
        }

    }
}
