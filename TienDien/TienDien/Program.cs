using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{

    public class Program
    {
        public static void Main(string[] args)
        {

            List<KHVN> ab = new List<KHVN>();
            List<KHNN> ac = new List<KHNN>();

            KHVN KHVN1 = new KHVN();
            KHVN1.id = "1";
            KHVN1.name = "Lê Đức Duy";
            KHVN1.date = "2020-05-06";
            KHVN1.soluong = 175;
            KHVN1.doituong = KHVN1.danhsachdoituong[0];
            KHVN1.hienthi();
            ab.Add(KHVN1);

            KHVN KHVN2 = new KHVN();
            KHVN2.id = "2";
            KHVN2.name = "Lê Đức Duy";
            KHVN2.date = "2020-05-06";
            KHVN2.soluong = 300;
            KHVN2.doituong = KHVN2.danhsachdoituong[0];
            KHVN2.hienthi();
            ab.Add(KHVN2);

            KHNN KHNN1 = new KHNN();
            KHNN1.id = "1";
            KHNN1.name = "Alexsander";
            KHNN1.date = "2020-06-04";
            KHNN1.quoctich = " Japan";
            KHNN1.soluong = 350;
            KHNN1.hienthi();
            ac.Add(KHNN1);

            KHNN KHNN2 = new KHNN();
            KHNN2.id = "2";
            KHNN2.name = "Alexsander";
            KHNN2.date = "2020-06-04";
            KHNN2.quoctich = " Italy";
            KHNN2.soluong = 350;
            KHNN2.hienthi();
            ac.Add(KHNN2);

          /*  double tongslvn = 0;
            for(int i=0; i<100; i++)
            {
                tongslvn = tongslvn + ab.[i]
            }

            Console.WriteLine("Tổng số lượng tiêu thụ khách hàng VN" + tongslvn);

            double tongslnn = 0;
            for (int i = 0; i < 100; i++)
            {
                tongslnn = tongslnn + 
            }*/

        }
    }
}
