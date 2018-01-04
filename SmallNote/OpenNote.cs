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
        public delegate void NewNoteEventHander();
        public event NewNoteEventHander NewNoteEvent;
        protected virtual void NewNEvent(EventArgs e)
        {
            if (NewNoteEvent != null)
            {
                NewNoteEvent();
            }
        }
        public void Opennote()
        {
            Console.WriteLine("现已打开笔记本");
            String Opentext = string.Empty;
            StreamReader sr = new StreamReader(@"g:\notebook\notebook.txt");
            Opentext = sr.ReadToEnd();//调用该方法读取文件中的全部内容
            Console.WriteLine(Opentext);
            sr.Close();


            Console.WriteLine("是否需要新建笔括记（y/n）");
            string a = Console.ReadLine();
            if (a.Equals("y"))
            {

                EventArgs e = new EventArgs();
                NewNEvent(e);
            }
            else
            { }

        }
    }
}
