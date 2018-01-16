using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operate1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 上机1

            //int[] points = new int[5];//历史积分数组
            //int[] newPoints = new int[5];//新年积分数组
            //Console.WriteLine("请输入5位会员的积分");
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.Write("第" + (i + 1) + "位会员积分");
            //    points[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < points.Length; i++)
            //{
            //    newPoints[i] = points[i];
            //    newPoints[i] = newPoints[i] + 500;//赠送500积分
            //}
            //Console.WriteLine("\n 序号 历史积分 新年积分");
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + "\t" + points[i] + "\t" + newPoints[i]);
            //}
            //Console.ReadLine();

            #endregion

            #region 上机2

            //string[] Computers = new string[] { "hpCQ-217TX", "Mc240CH/A", "SYNM18H/W" };
            //string[] time = new string[] { "2013/10/5", "2013/10/5", "2013/10/5" };
            //Console.WriteLine("******设置计算机ID前******");
            //Console.WriteLine("计算机型号 计算机ID 购买时间");
            //for (int i = 0; i < Computers.Length; i++)
            //{
            //    Console.WriteLine(Computers[i] + "\t\t\t" + time[0]);
            //}


            //Console.ReadLine();

            #endregion

            #region 上级三

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            #endregion
        }
    }
}
