namespace laba_2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Organization o = new Organization();
            Faculty f = new Faculty("sds", "232", "djdfnj fjd");
            Unversity u = new Unversity("sds", "232", "djdfnj fjd");

            Console.WriteLine(f.Name);
            Console.WriteLine(u.address);

            Console.WriteLine(u.printJobVacancies());

            Console.WriteLine(f.getJobVacancies());
            Console.WriteLine(o.getJobVacancies());

            Console.WriteLine(f.addJobTitle(new JobTitle()));
        }
    }

    public class Organization : IStaff
    {
        public int Id { get; private set; }
        public string Name { get; protected set; }
        public string shortName { get; protected set; }
        public string address { get; protected set; }
        public DateTime timeStamp { get; protected set; }

        public Organization()
        {

        }

        public Organization(string name, string shortName, string address)
        {
            this.Name = name;
            this.shortName = shortName;
            this.address = address;
        }

        public void printInfo()
        {
            Console.WriteLine($"Name: {Name}, shortName: {shortName}, address: {address}");
        }

        public List<JobVacancy> getJobVacancies()
        {
            return new List<JobVacancy>();
        }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>();
        }

        public List<JobTitle> GetJobTitles()
        {
            return new List<JobTitle>();
        }

        public int addJobTitle(JobTitle j)
        {
            return -121;
        }

        public string printJobVacancies()
        {
            return " sd";
        }

        public bool delJobTitle(int i)
        {
            return false;
        }

        public void openJobVacancy(JobVacancy j)
        {
            return;
        }

        public bool closeJobVacancy(int i)
        {
            return true;
        }

        public Employee recruit(JobVacancy j, Person p)
        {
            return new Employee();
        }

        public bool dismiss(int i, Reason s)
        {
            return true;
        }
    }

    public class Unversity : Organization, IStaff
    {
        protected List<Faculty> faculties;
        public Unversity() { }
        public Unversity(Unversity u)
        {
            this.faculties = u.faculties;
        }
        public Unversity(string name, string shortName, string address) : base(name, shortName, address) { }

        public int addFaculty(Faculty f)
        {
            faculties.Add(f);
            return faculties.Count;
        }

        public bool delFaculty(int index)
        {
            try
            {
                faculties.RemoveAt(index);
                return true;
            }
            catch { return false; }
        }

        public bool updFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
            return true;
        }

        private bool verFaculty(int i)
        {
            return faculties.Count > i;
        }

        public List<Faculty> GetFaculties()
        {
            return faculties;
        }

        public void printInfo()
        {
            foreach (var f in faculties)
            {
                Console.WriteLine(f);
            }
        }

        public List<JobVacancy> getJobVacancies()
        {
            return new List<JobVacancy>();
        }

        public int addJobTitle(JobTitle j)
        {
            return 1;
        }

        public bool delJobTitle(int i)
        {
            return false;
        }

        public int openJobVacancy(JobVacancy jv)
        {
            return 0;
        }

        public bool closeJobVacancy(int i)
        {
            return false;
        } 

        public Employee recruit(JobVacancy jw, Person p)
        {
            return new Employee();
        }

        public void dismiss(int i, Reason s)
        {
            return;
        }
    }



    public class Faculty : Organization, IStaff
    {
        protected List<Department> departments;

        public Faculty() { }

        public Faculty(Faculty f)
        {
            departments = f.departments;
        }

        public Faculty(string name, string shortName, string address) : base(name, shortName, address)
        {

        }

        public int addDepartment(Department department)
        {
            departments.Add(department);
            return departments.Count;
        }

        public bool delDepartment(int i)
        {
            departments.RemoveAt(i);
            return true;
        }

        public bool updDepartment(Department d)
        {
            return false;
        }

        private bool verDepartment(int i)
        {
            return false;
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public List<JobVacancy> getJobVacancies()
        {
            return new List<JobVacancy>();
        }

        public int addJobTitle(JobTitle j)
        {
            return 1;
        }

        public bool delJobTitle(int i)
        {
            return false;
        }

        public int openJobVacancy(JobVacancy jv)
        {
            return 0;
        }

        public bool closeJobVacancy(int i)
        {
            return false;
        }

        public Employee recruit(JobVacancy jw, Person p)
        {
            return new Employee();
        }

        public void dismiss(int i, Reason s)
        {
            return;
        }
    }

    public interface IStaff
    {
        List<JobVacancy> getJobVacancies();
        List<Employee> GetEmployees();
        List<JobTitle> GetJobTitles();
        int addJobTitle(JobTitle j);
        string printJobVacancies();
        bool delJobTitle(int i);
        void openJobVacancy(JobVacancy j);
        bool closeJobVacancy(int i);
        Employee recruit(JobVacancy j, Person p);
        bool dismiss(int i, Reason s);
    }

    public class JobVacancy
    {

    }

    public class Department
    {
    }

    public class JobTitle
    {

    }

    public class Person
    {

    }

    public class Employee
    {

    }

    public class Reason { }
}