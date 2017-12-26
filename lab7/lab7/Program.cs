using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static List<office.Worker> workers = new List<office.Worker>()
        {
            new office.Worker(1, "Лескина ", 1),
            new office.Worker(2, "Брысина ", 4),
            new office.Worker(3, "Байбарин ", 2),
            new office.Worker(4, "Гаврилюк ", 3),
            new office.Worker(5, "Баскакова ", 3),
            new office.Worker(6, "Кондрашева ", 4),
            new office.Worker(7, "Тимаков ", 1),
            new office.Worker(8, "Авдеев ", 2),
            new office.Worker(9, "Александрова ", 2),
        };
        static List<office.Department> rooms = new List<office.Department>()
        {
            new office.Department(1, "Отдел финансов "),
            new office.Department(2, "Общий отдел "),
            new office.Department(3, "Отдел кадров "),
            new office.Department(4, "IT отдел ")
        };
        static List<office.Relations> rel = new List<office.Relations>()
        {
            new office.Relations(1, 1),
            new office.Relations(2, 4),
            new office.Relations(3, 2),
            new office.Relations(4, 3),
            new office.Relations(5, 3),
            new office.Relations(6, 4),
            new office.Relations(7, 1),
            new office.Relations(8, 2),
            new office.Relations(9, 2),
            new office.Relations(6, 3),
            new office.Relations(7, 2),
            new office.Relations(8, 4),
            new office.Relations(9, 1)
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Перечисление всех сотрудников:");
            var i1 = from x in workers select x;
            foreach (var x in i1) Console.WriteLine(x);

            Console.WriteLine("\nПеречисление всех офисов:");
            var i2 = from x in rooms select x;
            foreach (var x in i2) Console.WriteLine(x);

            Console.WriteLine("\nCписок всех сотрудников, отсортированный по отделам:");
            foreach (var r in rooms)
            {
                var i3 = from x in workers where r.id_department == x.id_department select x;
                foreach (var x in i3) Console.WriteLine(x);
            }

            Console.WriteLine("\nCписок всех сотрудников, фамилия которых начинается на А:");
            foreach (var x in workers)
                if (x.surname[0] == 'А') Console.WriteLine(x);
            
            Console.WriteLine("\nCписок всех отделов и количество сотрудников в каждом отделе");
            foreach (var x in rooms)
            {
                int num = workers.Count(y => y.id_department == x.id_department);
                Console.WriteLine(x + "Количество=" + num);
            }

            Console.WriteLine("\nCписок отделов, в которых у всех сотрудников фамилия начинается с буквы А");
            var i4 = from x in rooms
                     where (workers.Count(y => y.surname[0] == 'А' && y.id_department == x.id_department) == workers.Count(y => y.id_department == x.id_department))
                     select x;
            foreach (var x in i4) Console.WriteLine(x);
            if (i4.Count() == 0)
            {
                Console.WriteLine("Таких отделов нет");
            }

            Console.WriteLine("\nСписок отделов, в которых хотя бы у одного сотрудника фамилия начинается с буквы А");
            var i5 = from x in rooms
                     where (workers.Count(y => y.surname[0] == 'А' && y.id_department == x.id_department) > 0)
                     select x;
            foreach (var x in i5) Console.WriteLine(x);
            Console.WriteLine("\nДля связи Отдел и Сотрудник М:М:");
            Console.WriteLine("Вывести список всех отделов и список сотрудников в каждом отделе");
            foreach (var x in rooms)
            {
                //Перебор по связям отдел-сотрудник
                var i6 = from y in rel
                         where (y.id_department == x.id_department)
                         select y;
                //Перебор по списку сотрудников
                var i7 = from y in workers
                         from z in i6
                         where (z.id_worker == y.id_worker)
                         select y;
                Console.WriteLine(x);
                foreach (var y in i7) Console.WriteLine(y);
            }

            Console.WriteLine("\nВывести список всех отделов и количество сотрудников в каждом отделе");
            foreach (var x in rooms)
            {
                //Перебор по связям отдел-работник
                var i8 = from y in rel
                         where (y.id_department == x.id_department)
                         select y;
                Console.WriteLine(x + " " + i8.Count());
            }
            Console.ReadLine();
        }
    }
}

namespace office 
{
    class Worker
    {
        public int id_worker;
        public string surname;
        public int id_department;
        public Worker() {}
        public Worker(int a, string s, int b)
        {
            this.id_worker = a;
            this.surname = s;
            this.id_department = b;
        }
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            return "id_worker=" + this.id_worker.ToString() + "| surname=" + this.surname + b.Append(Convert.ToChar(32), 20 - this.surname.Length ) 
                + "| id_department= " + this.id_department + "|";
        }
    }
    class Department 
    { 
        public int id_department;
        public string title;
        public Department() { }
        public Department(int a, string s)
        {
            this.id_department = a;
            this.title = s;
        }
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            return "id_department=" + this.id_department.ToString() + "| title=" + this.title.ToString() + b.Append(Convert.ToChar(32), 15 - this.title.Length) + "|";
        }
    }
    class Relations { 
        public int id_worker;
        public int id_department;
        public Relations(int a, int b)
        {
            this.id_worker = a;
            this.id_department = b;
        }
        public override string ToString()
        {
            return "workerid=" + this.id_worker.ToString() + "| OfficeID=" + this.id_department + "|";
        }
    }
}
