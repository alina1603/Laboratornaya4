using System;

namespace lab4
{
    /// <summary>
    /// Класс <c>MySQL</c>,
    /// отвечающий за реализацию методов работы с MySQL.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateTable</term>
    /// <description>Метод для обновления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Select</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Insert</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Merge</term>
    /// <description>Метод для слияния.</description>
    /// </item>
    /// <item>
    /// <term>AlterUser</term>
    /// <description>Метод для изменения пользователя БД.</description>
    /// </item>
    /// <item>
    /// <term>ContactDBA</term>
    /// <description>Метод для связи в администратором БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class MySQL : BD_interface
    {
        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        public void CreateTable()
        {
            Console.WriteLine("Create some table in MySQL database");
        }
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        public void DropTable()
        {
            Console.WriteLine("Drop some table in MySQL database");
        }
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        public void AlterTable()
        {
            Console.WriteLine("Alter some table in MySQL database");
        }
        /// <summary>
        /// Метод для обновления таблицы.
        /// </summary>
        public void UpdateTable()
        {
            Console.WriteLine("Update some table in MySQL database");
        }
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        public void Select()
        {
            Console.WriteLine("Select some data in MySQL database");
        }
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        public void Insert()
        {
            Console.WriteLine("Insert some data in MySQL database");
        }
        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        public void Delete()
        {
            Console.WriteLine("Delete some data in MySQL database");
        }
        /// <summary>
        /// Метод для слияния данных в таблице.
        /// </summary>
        public void Merge()
        {
            Console.WriteLine("Merge some data in MySQL database");
        }
        /// <summary>
        /// Метод для изменения пользователя.
        /// </summary> 
        public void AlterUser()
        {
            Console.WriteLine("Alter some user in MySQL database");
        }
        /// <summary>
        /// Метод для связи с администратором базы данных.
        /// </summary>
        public void ContactDBA()
        {
            Console.WriteLine("Contacting your MySQL database administrator");
        }
    }
    /// <summary>
    /// Класс <c>Oracle</c>,
    /// отвечающий за реализацию методов работы с Oracle.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateTable</term>
    /// <description>Метод для обновления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Select</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Insert</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Merge</term>
    /// <description>Метод для слияния.</description>
    /// </item>
    /// <item>
    /// <term>AlterUser</term>
    /// <description>Метод для изменения пользователя БД.</description>
    /// </item>
    /// <item>
    /// <term>ContactDBA</term>
    /// <description>Метод для связи в администратором БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class Oracle : BD_interface
    {
        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        public void CreateTable()
        {
            Console.WriteLine("Create some table in Oracle database");
        }
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        public void DropTable()
        {
            Console.WriteLine("Drop some table in Oracle database");
        }
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        public void AlterTable()
        {
            Console.WriteLine("Alter some table in Oracle database");
        }
        /// <summary>
        /// Метод для обновления таблицы.
        /// </summary>
        public void UpdateTable()
        {
            Console.WriteLine("Update some table in Oracle database");
        }
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        public void Select()
        {
            Console.WriteLine("Select some data in Oracle database");
        }
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        public void Insert()
        {
            Console.WriteLine("Insert some data in Oracle database");
        }
        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        public void Delete()
        {
            Console.WriteLine("Delete some data in Oracle database");
        }
        /// <summary>
        /// Метод для слияния данных в таблице.
        /// </summary>
        public void Merge()
        {
            Console.WriteLine("Merge some data in Oracle database");
        }
        /// <summary>
        /// Метод для изменения пользователя.
        /// </summary>  
        public void AlterUser()
        {
            Console.WriteLine("Alter some user in Oracle database");
        }
        /// <summary>
        /// Метод для связи с администратором базы данных.
        /// </summary>
        public void ContactDBA()
        {
            Console.WriteLine("Contacting your Oracle database administrator");
        }
    }
    /// <summary>
    /// Класс <c>PostgreSQL</c>,
    /// отвечающий за реализацию методов работы с PostgreSQL.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateTable</term>
    /// <description>Метод для обновления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Select</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Insert</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Merge</term>
    /// <description>Метод для слияния.</description>
    /// </item>
    /// <item>
    /// <term>AlterUser</term>
    /// <description>Метод для изменения пользователя БД.</description>
    /// </item>
    /// <item>
    /// <term>ContactDBA</term>
    /// <description>Метод для связи в администратором БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class PostgreSQL : BD_interface
    {
        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        public void CreateTable()
        {
            Console.WriteLine("Create some table in PostgreSQL database");
        }
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        public void DropTable()
        {
            Console.WriteLine("Drop some table in PostgreSQL database");
        }
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        public void AlterTable()
        {
            Console.WriteLine("Alter some table in PostgreSQL database");
        }
        /// <summary>
        /// Метод для обновления таблицы.
        /// </summary>
        public void UpdateTable()
        {
            Console.WriteLine("Update some table in PostgreSQL database");
        }
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        public void Select()
        {
            Console.WriteLine("Select some data in PostgreSQL database");
        }
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        public void Insert()
        {
            Console.WriteLine("Insert some data in PostgreSQL database");
        }
        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        public void Delete()
        {
            Console.WriteLine("Delete some data in PostgreSQL database");
        }
        /// <summary>
        /// Метод для слияния данных в таблице.
        /// </summary>
        public void Merge()
        {
            Console.WriteLine("Merge some data in PostgreSQL database");
        }
        /// <summary>
        /// Метод для изменения пользователя.
        /// </summary> 
        public void AlterUser()
        {
            Console.WriteLine("Alter some user in PostgreSQL database");
        }
        /// <summary>
        /// Метод для связи с администратором базы данных.
        /// </summary>
        public void ContactDBA()
        {
            Console.WriteLine("Contacting your PostgreSQL database administrator");
        }
    }
    /// <summary>
    /// Интерфейс <c>BD_interface</c>.
    /// Представляет методы, реализующие функционал любой СУБД.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateTable</term>
    /// <description>Метод для обновления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Select</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Insert</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>Merge</term>
    /// <description>Метод для слияния.</description>
    /// </item>
    /// <item>
    /// <term>AlterUser</term>
    /// <description>Метод для изменения пользователя БД.</description>
    /// </item>
    /// <item>
    /// <term>ContactDBA</term>
    /// <description>Метод для связи в администратором БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface BD_interface
    {
        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        void CreateTable();
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        void DropTable();
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        void AlterTable();
        /// <summary>
        /// Метод для обновления таблицы.
        /// </summary>
        void UpdateTable();
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        void Select();
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        void Insert();
        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        void Delete();
        /// <summary>
        /// Метод для слияния данных в таблице.
        /// </summary>
        void Merge();
        /// <summary>
        /// Метод для изменения пользователя.
        /// </summary> 
        void AlterUser();
        /// <summary>
        /// Метод для связи с администратором базы данных.
        /// </summary>
        void ContactDBA();
    }
    /// <summary>
    /// Класс - контроль <c>BD_realize</c>.
    /// <list type="bullet">
    /// <item>
    /// <term>bd</term>
    /// <description>Поле, представляющее объект класса <c>BD_interface</c>,
    /// отвечающее за то, к какой СУБД необходим доступ.</description>
    /// </item>
    /// <item>
    /// <term>BD_realize</term>
    /// <description>Конструктор класса.</description>
    /// </item>
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод, позволяющий получить доступ к методу CreateTable
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод, позволяющий получить доступ к методу DropTable
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод, позволяющий получить доступ к методу AlterTable
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>UpdateTable</term>
    /// <description>Метод, позволяющий получить доступ к методу UpdateTable
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>Select</term>
    /// <description>Метод, позволяющий получить доступ к методу Select
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>Insert</term>
    /// <description>Метод, позволяющий получить доступ к методу Insert
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Метод, позволяющий получить доступ к методу Delete
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>Merge</term>
    /// <description>Метод, позволяющий получить доступ к методу Merge
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>AlterUser</term>
    /// <description>Метод, позволяющий получить доступ к методу AlterUser
    /// через объект bd.</description>
    /// </item>
    /// <item>
    /// <term>ContactDBA</term>
    /// <description>Метод, позволяющий получить доступ к методу ContactDBA
    /// через объект bd.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class BD_realize
    {
        /// <summary>
        /// Поле, представляющее объект класса <c>BD_interface</c>,
        /// отвечающее за то, к какой СУБД необходим доступ.
        /// </summary>
        private readonly BD_interface bd;
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public BD_realize(BD_interface bd)
        {
            this.bd = bd;
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу CreateTable через объект bd.
        /// </summary>
        public void CreateTable()
        {
            bd.CreateTable();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу DropTable через объект bd.
        /// </summary>
        public void DropTable()
        {
            bd.DropTable();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу AlterTable через объект bd.
        /// </summary>
        public void AlterTable()
        {
            bd.AlterTable();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу UpdateTable через объект bd.
        /// </summary>
        public void UpdateTable()
        {
            bd.UpdateTable();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу Select через объект bd.
        /// </summary>
        public void Select()
        {
            bd.Select();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу Insert через объект bd.
        /// </summary>
        public void Insert()
        {
            bd.Insert();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу Delete через объект bd.
        /// </summary>
        public void Delete()
        {
            bd.Delete();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу Merge через объект bd.
        /// </summary>
        public void Merge()
        {
            bd.Merge();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу AlterUser через объект bd.
        /// </summary>
        public void AlterUser()
        {
            bd.AlterUser();
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу ContactDBA через объект bd.
        /// </summary>
        public void ContactDBA()
        {
            bd.ContactDBA();
        }

    }

    /// <summary>
    /// Главный класс Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Обьявление объекта класса BD_realize.
        /// </summary>
        public static BD_realize dostup;
        /*Метод, который используется для создания объекта класса BD_realize на основе входных данных.*/
        /// <summary>
        /// Метод Initialization для инициализации объекта dostup на основе данных, полученных от пользователя.
        /// </summary>
        ///<param name="bd_num">Строка-номер СУБД.</param>
        ///<param name="comands">Массив строк-номеров, каждый из которых соответствует команде СУБД.</param>
        private static void Initialization(string bd_num, string[] comands)
        {

                switch (bd_num) /*В зависимости от числа определяется, к какой СУБД нужен доступ.*/
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
                switch (s) /*В зависимости от числа определяется, к какой команде СУБД нужен доступ.*/
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
                    default:
                        Console.WriteLine("Такой команды не существует.");
                        break;
                }
            }
        }
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            try
            { 
                string number;
                string[] comands;
                string command;
                int prov;
                /*Запрос у пользователя названия СУБД и необходимых команд.*/
                Console.WriteLine("Введите номер выбранной СУБД:\r\n1. MySQL\r\n2. Oracle\r\n3. PostgreSQL");
                number = Console.ReadLine();
                try
                {
                    prov = Convert.ToInt32(number);
                }
                catch
                {
                    Console.WriteLine("Ошибка при выборе СУБД!");
                    Console.ReadLine();
                    return;
                }
                if (prov > 3)
                {
                    Console.WriteLine("Ошибка при выборе СУБД!");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("Введите через пробел номера команд для выполнения:\r\n1. Create table\r\n2. Drop table\r\n3. Alter table\r\n" +
                    "4. Update table\r\n5. Select\r\n6. Insert\r\n" +
                    "7. Delete\r\n8. Merge\r\n9. Alter user\r\n10. Contact database administrator");
                command = Console.ReadLine();
                comands = command.Split(new char[] { ' ' });
                /*Вызов метода, который соберет объект для доступа к командам СУБД на основе входных данных.*/
                Initialization(number, comands);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}