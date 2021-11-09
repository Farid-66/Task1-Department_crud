using System;

namespace Department_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choise = 1;
            DepartmentService departmentService = new DepartmentService();
            Console.WriteLine("##################-Department Service System-#####################");
            Console.WriteLine();
            do
            {
                Console.WriteLine("You can choose from following:");
                Console.WriteLine(" ________________________________________________________________");
                Console.WriteLine("|            |           |             |             |           |");
                Console.WriteLine("| Creat [1]. | Read [2]. | UpDate [3]. | Delete [4]. | Exit [0]. |");
                Console.WriteLine("|____________|___________|_____________|_____________|___________|");
                Console.WriteLine("");
                Console.Write("Choose: ");
                Console.WriteLine("");
                if (byte.TryParse(Console.ReadLine(), out choise))
                {
                    switch (choise)
                    {
                        case 1:

                            Department newDep = new Department();
                            Console.WriteLine("___________________Creat_________________________");
                            Console.Write("Enter the Id:");
                            newDep.Id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter the department name:");
                            newDep.Name = Console.ReadLine();

                            Console.Write("Enter the EmployeeCount:");
                            newDep.EmployeeCount = Convert.ToInt32(Console.ReadLine()); 

                            departmentService.Create(newDep);
                            Console.WriteLine("New department added successfully!");
                            Console.WriteLine();
                            break;

                        case 2:

                            Department[] departments = departmentService.Read();
                            Console.WriteLine("___________________Read_________________________");

                            for (int i = 0; i < departments.Length; i++)
                            {
                                Console.WriteLine($"| ID:{departments[i].Id}|     Name: {departments[i].Name},   EmployeeCount:{departments[i].EmployeeCount}");
                            }
                            Console.WriteLine();
                            break;

                        case 3:

                            Console.WriteLine("___________________UpDate_________________________");

                            foreach (var item in departmentService.Read())
                            {
                                Console.WriteLine($"| ID:{item.Id}|     Name: {item.Name},   EmployeeCount: {item.EmployeeCount}");
                            }
                            Console.Write("Choose ID: ");
                            int depId = Convert.ToInt32(Console.ReadLine());
                            Department department = departmentService.Find(depId);

                            Console.Write($"Ente new name({department.Name}): ");
                            department.Name = Console.ReadLine();

                            Console.Write($"Ente new EmployeeCount({department.EmployeeCount}): ");
                            department.EmployeeCount = Convert.ToByte(Console.ReadLine());

                            departmentService.Update(depId, department);

                            Console.WriteLine("UpDated successfully!");
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.WriteLine("___________________Delete_________________________");

                            Department[] departments1 = departmentService.Read();
                            for (int i = 0; i < departments1.Length; i++)
                            {
                                Console.WriteLine($"| ID:{departments1[i].Id}|     Name: {departments1[i].Name},   EmployeeCount: {departments1[i].EmployeeCount}");
                            }
                            Console.Write("Choose ID: ");
                            int IdForDelete = Convert.ToInt32(Console.ReadLine());
                            departmentService.Delete(IdForDelete);
                            Console.WriteLine("Deleted successfully!");
                            break;

                        case 0:
                            Console.WriteLine("Exist");
                            break;
                        default:
                            Console.WriteLine("Error: You can only select from table!");
                            break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("You must enter the number from Table!");
                    Console.WriteLine();
                    choise = 1;
                }
            } while (choise != 0);
        }
    }
}
