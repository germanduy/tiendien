using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{
    public class KHVN
    {
        public string id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int soluong { get; set; }
        public double giatien { get; set; }
        public string doituong { get; set; }
        public string[] danhsachdoituong = { "sinh hoạt", "kinh doanh", " sản xuất" };
        int[] dinhmuc = { 50, 100, 200 };
        int[] dinhmucgia = { 1000, 1200, 1500, 2000 };

        public double tinhtien()
        {

            if (soluong < dinhmuc[0])
            {
                giatien = soluong * dinhmucgia[0];
            }
            else if (soluong < dinhmuc[1])
            {
                giatien = (dinhmuc[0] - 1) * dinhmucgia[0] + (soluong - dinhmuc[0]) * dinhmucgia[1];
            }
            else if (soluong < dinhmuc[2])
            {
                giatien = ((dinhmuc[0] - 1) * dinhmucgia[0] + (dinhmuc[1] - dinhmuc[0] - 1) *  dinhmucgia[1] + (soluong - dinhmuc[1]) * dinhmucgia[2]);
            }
            else
            {
                giatien = ((dinhmuc[0] - 1) *  dinhmucgia[0] + (dinhmuc[1] - dinhmuc[0] - 1) * dinhmucgia[1] + (dinhmuc[2] - dinhmuc[1] - 1) * dinhmucgia[2]) +(soluong - dinhmuc[2]) * dinhmucgia[3];
            }
            return giatien;
        }

        public void hienthi()
        {
            Console.WriteLine("\n Thông tin hóa đơn");
            Console.WriteLine("Mã khách hàng" + id);
            Console.WriteLine("Tên khách hàng" + name);
            Console.WriteLine("Ngày hóa đơn"+ date);
            Console.WriteLine("Đối tượng khách hàng" + doituong);
            Console.WriteLine("Số lượng tiêu thụ" + soluong);
            Console.WriteLine("Thành tiền" + tinhtien());
        }
        
    }
}
