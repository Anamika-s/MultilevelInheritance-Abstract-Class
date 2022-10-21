using System;
using System.Collections.Generic;
using System.Text;

     namespace InheritanceDemos
    {
        class Employee
        {
            int id;
            string name;
            string dept;
            string manager;
            public Employee()
            {

            }
            public Employee(int id, string name, string dept, string manager)
            {
                this.id = id;
                this.name = name;
                this.dept = dept;
                this.manager = manager;
            }
            public virtual void GetDetails()
            {
                Console.WriteLine("Enter ID");
                id = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter dept");
                dept = Console.ReadLine();
                Console.WriteLine("Enter manager");
                manager = Console.ReadLine();
            }
            public virtual void DisplayDetails()
            {
                Console.WriteLine($"Id: {id}\nName: {name}\nDept: {dept}\nManager: {manager}");
            }
        }



    class ParttimeEmployee : Employee
    {
        string projectName;
        string duration;
        public ParttimeEmployee() : base() { }
        public ParttimeEmployee(int id, string name, string dept, string manager, string projectName, string duration)
            : base(id, name, dept, manager)
        {
            this.projectName = projectName;
            this.duration = duration;
        }
        
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Project Name");
            projectName = Console.ReadLine();
            Console.WriteLine("Enter Duration");
            duration = Console.ReadLine();
        }
         public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Project Name: {projectName}\nDuration is: {duration}");
        }
    }

    class FullTimEmployee : Employee
    {
        int salary;
        string designation;
        public FullTimEmployee() : base() { }
        public FullTimEmployee(int id, string name, string dept, string manager, int salary, string designation)
            : base(id, name, dept, manager)
        {
            this.salary = salary;
            this.designation = designation;
        }
         public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter salary");
            salary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter designation");
            designation = Console.ReadLine();
        }
         public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"salary: {salary}\ndesignation is: {designation}");
        }
    }

    class Demo
    {
         static void Main()
        {
            Employee employee;
            employee = new ParttimeEmployee();
            employee.GetDetails();
            employee = new FullTimEmployee();
            employee.GetDetails();
            employee.DisplayDetails();



        }
    }
}



