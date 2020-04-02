using System;

namespace lab4
{

    public class MySQL : BD_interface
    {

        public void CreateTable()
        {
            Console.WriteLine("Create some table in MySQL database");
        }

        public void DropTable()
        {
            Console.WriteLine("Drop some table in MySQL database");
        }

        public void AlterTable()
        {
            Console.WriteLine("Alter some table in MySQL database");
        }

        public void UpdateTable()
        {
            Console.WriteLine("Update some table in MySQL database");
        }

        public void Select()
        {
            Console.WriteLine("Select some data in MySQL database");
        }

        public void Insert()
        {
            Console.WriteLine("Insert some data in MySQL database");
        }

        public void Delete()
        {
            Console.WriteLine("Delete some data in MySQL database");
        }

        public void Merge()
        {
            Console.WriteLine("Merge some data in MySQL database");
        }
   
        public void AlterUser()
        {
            Console.WriteLine("Alter some user in MySQL database");
        }

        public void ContactDBA()
        {
            Console.WriteLine("Contacting your MySQL database administrator");
        }
    }
  
    public class Oracle : BD_interface
    {

        public void CreateTable()
        {
            Console.WriteLine("Create some table in Oracle database");
        }

        public void DropTable()
        {
            Console.WriteLine("Drop some table in Oracle database");
        }

        public void AlterTable()
        {
            Console.WriteLine("Alter some table in Oracle database");
        }

        public void UpdateTable()
        {
            Console.WriteLine("Update some table in Oracle database");
        }

        public void Select()
        {
            Console.WriteLine("Select some data in Oracle database");
        }

        public void Insert()
        {
            Console.WriteLine("Insert some data in Oracle database");
        }

        public void Delete()
        {
            Console.WriteLine("Delete some data in Oracle database");
        }

        public void Merge()
        {
            Console.WriteLine("Merge some data in Oracle database");
        }
     
        public void AlterUser()
        {
            Console.WriteLine("Alter some user in Oracle database");
        }

        public void ContactDBA()
        {
            Console.WriteLine("Contacting your Oracle database administrator");
        }
    }
  
    public class PostgreSQL : BD_interface
    {

        public void CreateTable()
        {
            Console.WriteLine("Create some table in PostgreSQL database");
        }

        public void DropTable()
        {
            Console.WriteLine("Drop some table in PostgreSQL database");
        }

        public void AlterTable()
        {
            Console.WriteLine("Alter some table in PostgreSQL database");
        }

        public void UpdateTable()
        {
            Console.WriteLine("Update some table in PostgreSQL database");
        }

        public void Select()
        {
            Console.WriteLine("Select some data in PostgreSQL database");
        }

        public void Insert()
        {
            Console.WriteLine("Insert some data in PostgreSQL database");
        }

        public void Delete()
        {
            Console.WriteLine("Delete some data in PostgreSQL database");
        }

        public void Merge()
        {
            Console.WriteLine("Merge some data in PostgreSQL database");
        }
     
        public void AlterUser()
        {
            Console.WriteLine("Alter some user in PostgreSQL database");
        }

        public void ContactDBA()
        {
            Console.WriteLine("Contacting your PostgreSQL database administrator");
        }
    }
  
    public interface BD_interface
    {

        void CreateTable();

        void DropTable();

        void AlterTable();

        void UpdateTable();

        void Select();

        void Insert();

        void Delete();

        void Merge();
   
        void AlterUser();

        void ContactDBA();
    }

    public class BD_realize
    {

        private readonly BD_interface bd;

        public BD_realize(BD_interface bd)
        {
            this.bd = bd;
        }

        public void CreateTable()
        {
            bd.CreateTable();
        }

        public void DropTable()
        {
            bd.DropTable();
        }

        public void AlterTable()
        {
            bd.AlterTable();
        }

        public void UpdateTable()
        {
            bd.UpdateTable();
        }

        public void Select()
        {
            bd.Select();
        }
 
        public void Insert()
        {
            bd.Insert();
        }

        public void Delete()
        {
            bd.Delete();
        }

        public void Merge()
        {
            bd.Merge();
        }

        public void AlterUser()
        {
            bd.AlterUser();
        }

        public void ContactDBA()
        {
            bd.ContactDBA();
        }

    }


    class Program
    {

        public static BD_realize dostup;

        private static void Initialization(string bd_num, string[] comands)
        {

                switch (bd_num) 
                {
                    case "1":
                        MySQL mySQL_bd = new MySQL();
                        dostup = new BD_realize(mySQL_bd);
                        break;
                    case "2":
                        Oracle oracle_bd = new Oracle();
                        dostup = new BD_realize(oracle_bd);
                        break;
                    case "3":
                        PostgreSQL postgreSQL_bd = new PostgreSQL();
                        dostup = new BD_realize(postgreSQL_bd);
                        break;
                }

            foreach (string s in comands)
            {
                switch (s) 
                {
                    case "1":
                        dostup.CreateTable();
                        break;
                    case "2":
                        dostup.DropTable();
                        break;
                    case "3":
                        dostup.AlterTable();
                        break;
                    case "4":
                        dostup.UpdateTable();
                        break;
                    case "5":
                        dostup.Select();
                        break;
                    case "6":
                        dostup.Insert();
                        break;
                    case "7":
                        dostup.Delete();
                        break;
                    case "8":
                        dostup.Merge();
                        break;
                    case "9":
                        dostup.AlterUser();
                        break;
                    case "10":
                        dostup.ContactDBA();
                        break;

                }
            }
        }
        static void Main(string[] args)
        {

                string number;
                string[] comands;
                string command;
                Console.WriteLine("Введите номер выбранной СУБД:\r\n1. MySQL\r\n2. Oracle\r\n3. PostgreSQL");
                number = Console.ReadLine();
                Console.WriteLine("Введите через пробел номера команд для выполнения:\r\n1. Create table\r\n2. Drop table\r\n3. Alter table\r\n" +
                    "4. Update table\r\n5. Select\r\n6. Insert\r\n" +
                    "7. Delete\r\n8. Merge\r\n9. Alter user\r\n10. Contact database administrator");
                command = Console.ReadLine();
                comands = command.Split(new char[] { ' ' });
                Initialization(number, comands);
            Console.ReadLine();
        }
    }
}