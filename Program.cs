using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    internal class Program
    {
        
        
            public static List<Employee> emplist = new List<Employee>
            {
                new Employee() {EmployeeID = 1001,FirstName = "Malcolm",LastName = "Daruwalla",Title = "Manager",DOB = DateTime.Parse("1984-01-02"),DOJ = DateTime.Parse("2011-08-09"),City = "Mumbai"},
new Employee() {EmployeeID = 1002,FirstName = "Asdin",LastName = "Dhalla",Title = "AsstManager",DOB = DateTime.Parse("1984-08-20"),DOJ = DateTime.Parse("2012-7-7"),City = "Mumbai"},
new Employee() {EmployeeID = 1003,FirstName = "Madhavi",LastName = "Oza",Title = "Consultant",DOB = DateTime.Parse("1987-11-14"),DOJ = DateTime.Parse("2015-4-12"),City = "Pune"},
new Employee() {EmployeeID = 1004,FirstName = "Saba",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"),City = "Pune"},
new Employee() {EmployeeID = 1005,FirstName = "Nazia",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"),City = "Mumbai"},
new Employee() {EmployeeID = 1006,FirstName = "Suresh",LastName = "Pathak",Title = "Consultant",DOB = DateTime.Parse("11/7/1989"),DOJ = DateTime.Parse("8/8/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1007,FirstName = "Vijay",LastName = "Natrajan",Title = "Consultant",DOB = DateTime.Parse("12/2/1989"),DOJ = DateTime.Parse("6/1/2015"),City = "Mumbai"},
new Employee() {EmployeeID = 1008,FirstName = "Rahul",LastName = "Dubey",Title = "Associate",DOB = DateTime.Parse("11/11/1993"),DOJ = DateTime.Parse("11/6/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1009,FirstName = "Amit",LastName = "Mistry",Title = "Associate",DOB = DateTime.Parse("8/12/1992"),DOJ = DateTime.Parse("12/3/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1010,FirstName = "Sumit",LastName = "Shah",Title = "Manager",DOB = DateTime.Parse("4/12/1991"),DOJ = DateTime.Parse("1/2/2016"),City = "Pune"}
           };
        static void Main(string[] args)
        {
            //DisplayAll();
            // Notmumbai();
            //TitleAsstManager();
            //LastNm();
            //DateofJoiningBefore();
            //DateofBirthAfter();
            EmployeesJoinedAfter();
            //ConsultantandAssociate();
            //TotalEmployees();
            // EmployeesBelongingto();
            //HighestEmployeeId();
            //NotAssociate();
            Console.ReadKey();
        }
        public static void DisplayAll()
        {
            var displayallemployees = (from Emp in emplist select Emp);
            foreach(var e in displayallemployees)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }
        public static void Notmumbai()
        {
            var NotMumbaiList = (from e in emplist where e.City!="Mumbai" select e);
            foreach (var e in NotMumbaiList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }
        public static void TitleAsstManager()
        {
            var Titleasstmanager = (from e in emplist where e.Title == "AsstManager" select e);
            foreach (var e in Titleasstmanager)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }
        public static void LastNm()
        {
            var lastnm = (from e in emplist where e.LastName.StartsWith("S") select e);
            foreach (var e in lastnm)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }
         public static void DateofJoiningBefore()
         {
            var dateogjoiningbefore = from emp in emplist where emp.DOJ < DateTime.Parse("1/1/2015") select emp;
            foreach (var obj in dateogjoiningbefore)
            {
                Console.WriteLine(obj.EmployeeID + " " + obj.FirstName + " " + obj.LastName + " " + obj.Title + " " + obj.DOB + " " + obj.DOJ + " " + obj.City);
            }
        }
         public static void DateofBirthAfter()
         {
             var dateofjoiningafter = from emp in emplist where emp.DOB > DateTime.Parse("1/1/1990") select emp;
            foreach (var e in dateofjoiningafter)
             { 
                 Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
             }
         }
        public static void EmployeesJoinedAfter()
        {
            var employeesjoinedafter = emplist.Count(e => e.DOJ > DateTime.Parse("1/1/2015"));

            Console.WriteLine("Total number of Employees Joined After 1/1/2015 is: {0}", employeesjoinedafter);

        }
        public static void ConsultantandAssociate()
        {
            var consultantandassociate = (from e in emplist where (e.Title == "Consultant") || (e.Title == "Associate") select e);
            foreach (var e in consultantandassociate)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }
        public static void TotalEmployees()
        {
            var totalemployees = emplist.Count();
            
                Console.WriteLine("Total number of Employees: {0}" , totalemployees);
            
        }
        public static void EmployeesBelongingto()
        {
            var employeesbelongingto = emplist.Count(e => e.City == "Chennai");

            Console.WriteLine("Total number of Employees Belonging to Chennai are: {0}", employeesbelongingto);

        }
        public static void HighestEmployeeId()
        {
            var highestemployeeid = emplist.Max(e => e.EmployeeID);

            Console.WriteLine("Highest Employee Id is: {0}", highestemployeeid);

        }
        
        public static void NotAssociate()
        {
            var notassociate = emplist.Count(e => e.Title != "Associate");

            Console.WriteLine("Total number of Employees Whose Designation is not Associate is: {0}", notassociate);

        }
        
    }
}





