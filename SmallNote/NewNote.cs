using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmallNote
{
    class NewNote
    {
        public delegate void SaveEventHander(object sender, SaveType e);
        public event SaveEventHander SaveEvent;
        protected virtual void Save(SaveType e)
        {
            if (SaveEvent != null)
            {
                SaveEvent(this, e);
            }
        }

        public void Newnote()
        {

            FileStream NewText = File.Create(@"g:\notebook\notebook.txt");
            Console.WriteLine("笔本已新建完成");
            NewText.Close();

            Console.WriteLine("请输入笔记：");
            String text = Console.ReadLine();
            Console.WriteLine("是否要保存笔记（y/n）");
            string answer = Console.ReadLine();
            if (answer.Equals("y"))
            {
                SaveType t = new SaveType(text);
                Save(t);
            }
            else { }
        }

    }
}
