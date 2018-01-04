using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallNote
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveNote saven = new SaveNote();
            NewNote newn = new NewNote();
            OpenNote openn = new OpenNote();
            NewClass newc = new NewClass();
            ManagerClass mc = new ManagerClass();
            newn.SaveEvent += saven.Savenote;
            openn.NewNoteEvent += newn.Newnote;
            newc.SaveCEvent += saven.Savenote;
            mc.NewClassEvent += newc.Newclass;

            Console.WriteLine("      *****************************************      ");
            Console.WriteLine("      *   1.新建笔记本       2.打开笔记本?    *     ");
            Console.WriteLine("      *    3.新建分类       4.管理分类     *    ");
            Console.WriteLine("      *    5.保存笔记        6.退出         *        ");
            Console.WriteLine("      *****************************************      ");

            Console.WriteLine("请输入菜单选项1~6");
            String key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    newn.Newnote();
                    break;
                case "2":
                    openn.Opennote();
                    break;
                case "3":
                    newc.Newclass();
                    break;
                case "4":
                    mc.ShowClass();
                    break;

                case "6":
                    Console.WriteLine("退出");
                    break;
                default:
                    Console.WriteLine("请输入以上数字：");
                    break;


            }

            }
       

        }
    class SaveType : EventArgs
    {
        public readonly string text;
        public SaveType(String text)
        {
            this.text = text;
        }
    }
    }

