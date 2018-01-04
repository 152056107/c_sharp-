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
             Console.WriteLine("—————————————————————————— ");
            Console.WriteLine("                                                     ");
            Console.WriteLine("      1.新建笔记              2.打开笔记             ");
            Console.WriteLine("      3.新建分类              4.管理分类              ");
            Console.WriteLine("      5.保存笔记              6.退出                 ");
            Console.WriteLine("                                                     ");
            Console.WriteLine("—————————————————————————— ");
            bool  flag = true;
            int choose;
            while (flag)
            {
                Console.WriteLine("请输入菜单选项（1-6）");
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                    {
                            case 1:

                            newnote b = new newnote();
                            b.New(); break;

                            case 2:

                            opennote c = new opennote();
                            c.Open(); break;

                            case 3:
                            newclassify d = new newclassify();
                            d.Newc(); break;

                            case 4:
                            manageclassify e = new manageclassify();
                            e.Managec(); break;

                            case 5:
                            savenote f = new savenote();
                            f.Save(); break;

                            case 6:
                            quit g = new quit();
                            g.Quit();
                            flag = false;
                            break;

                    }
                }

            }
        class newnote
        {
            public void New()
            {
                Console.WriteLine("新建笔记");


            }
        }
        class opennote
        {
            public void Open()
            {
                Console.WriteLine("打开笔记");
            }
        }
        class newclassify
        {
            public void Newc()
            {
                Console.WriteLine("新建分类");

            }
        }
        class manageclassify
        {
            public void Managec()
            {
                Console.WriteLine("管理分类");

            }
        }
        class savenote
        {
            public void Save()
            {
                Console.WriteLine("保存笔记");

            }
        }
        class quit
        {
            public void Quit()
            {
                Console.WriteLine("已退出");

            }
        }

        }
    }

