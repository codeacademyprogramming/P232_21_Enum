using System;

namespace GroupTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[0];

            string opt;
            do
            {
                Console.WriteLine("1. Group yarat");
                Console.WriteLine("2. Qruplara bax");
                Console.WriteLine("3. Type-a gore qruplara bax");
                Console.WriteLine("0. Cixis");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.Write("No: ");
                        string no = Console.ReadLine();

                        Console.WriteLine("Types: ");
                        foreach (var item in Enum.GetValues(typeof(GroupType)))
                        {
                            Console.WriteLine($"{(byte)item} - {item}");
                        }
                        string type;
                        byte typeNum;
                        do
                        {
                            Console.Write("Select group type: ");
                            type = Console.ReadLine();
                        } while (!byte.TryParse(type,out typeNum) || !Enum.IsDefined(typeof(GroupType),typeNum));

                        //var typeEnum = Enum.Parse(typeof(GroupType), type);
                        var typeEnum = (GroupType)typeNum;

                        Group group = new Group { No = no, Type = (GroupType)typeEnum };
                        Array.Resize(ref groups, groups.Length + 1);
                        groups[groups.Length - 1] = group;
                        break;
                    case "2":
                        //for (int i = 0; i < groups.Length; i++)
                        //{
                        //    Console.WriteLine(groups[i].No+" - "+groups[i].Type);
                        //}
                        foreach (var gr in groups)
                        {
                            Console.WriteLine($"{gr.No} - {gr.Type}");
                        }
                        break;
                    case "3":
                        Console.Write("Type: ");
                        string searchType = Console.ReadLine();

                        foreach (var gr in groups)
                        {
                            if(gr.Type.ToString() == searchType)
                                Console.WriteLine($"{gr.No} - {gr.Type}");
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir!");
                        break;
                }

            } while (opt != "0");
        }
    }
}
