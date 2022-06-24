using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{
    public class KHNN
    {
        public string id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int soluong { get; set; }
        public double giatien { get; set; }
        public string quoctich { get; set; }

        public int dongia = 2000;

        public double tinhtien()
        {
            giatien = dongia * soluong;
            return giatien;
        }
        public void hienthi()
        {
            Console.WriteLine("\n Thông tin hóa đơn");
            Console.WriteLine("Mã khách hàng" + id);
            Console.WriteLine("Ngày hóa đơn" + date);
            Console.WriteLine("Quốc tịch khách hàng" + quoctich);
            Console.WriteLine("Số lượng tiêu thụ" + soluong);
            Console.WriteLine("Thành tiền" + tinhtien());
        }
    }

}
