using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmallNote
{
    class OpenNote
    {
        public void Opennote()
        {
            Console.WriteLine("已经打开笔记");
            String Opentext = string.Empty;
            StreamReader sr = new StreamReader(@"G:\notebook\notebook1.txt");
            Opentext = sr.ReadToEnd();//调用该方法读取文件中的全部内容
            Console.WriteLine(Opentext);
            sr.Close();
            Console.ReadKey();
        }
    }
}
