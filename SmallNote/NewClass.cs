using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SmallNote
{
    class NewClass
    {
        public delegate void SaveClassEventHander(object sender, SaveType e);
        public event SaveClassEventHander SaveCEvent;
        protected virtual void Save(SaveType e)
        {
            if (SaveCEvent != null)
            {
                SaveCEvent(this, e);
            }
        }

        public void Newclass()
        {
            Console.WriteLine("请输入新的科目");
            String type = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"g:\notebook\notebook.txt");
            sw.WriteLine(type);
            Console.WriteLine("该类型已保存成功");
            sw.Close();

            Console.WriteLine("是否要保存笔记（y/n）");
            string answer = Console.ReadLine();
            if (answer.Equals("y"))
            {
                //SaveNote sn = new SaveNote();
                //sn.Savenote(type);
                SaveType t = new SaveType(type);
                Save(t);
            }
            else { }

        }
    }
}
