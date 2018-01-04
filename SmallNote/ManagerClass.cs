using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmallNote
{
    class ManagerClass
    {
        public void ShowClas()
        {
            Console.WriteLine("可以查看笔记类型");
            String text = string.Empty;
            StreamReader sr = new StreamReader(@"G:\notebook\leixing.txt");
            text = sr.ReadToEnd();//调用该方法读取文件中的全部内容
            Console.WriteLine(text);
            sr.Close();
        }
    }
}
