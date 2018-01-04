using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmallNote
{
    class SaveNote
    {
        public void Savenote(object sender, SaveType text)
        {
            StreamWriter sw = new StreamWriter(@"g:\notebook\notebook.txt");
            sw.WriteLine(text);
            Console.WriteLine("笔记本保存成功");
            sw.Close();
        }
    }
}
