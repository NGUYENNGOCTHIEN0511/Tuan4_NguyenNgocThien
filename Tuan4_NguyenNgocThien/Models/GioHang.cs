using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tuan4_NguyenNgocThien.Models
{
    public class GioHang
    {
        MydataDataDataContext data = new MydataDataDataContext();
        public int masach { get; set; }

        [Display(Name  = "Ten Sach")]
        public String tensach { get; set; }


        [Display(Name = "Anh Bia")]
        public String hinh { get; set; }

        [Display(Name = "Gia ban")]
        public  Double giaban{ get; set; }

        [Display(Name =  "So luong")]
        public int iSoluong { get; set; }

        [Display(Name = "Thanh tien")]
        public Double dThanhtien
        {
            get { return iSoluong * giaban; }
        }
        public GioHang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n=> n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }
    }
}