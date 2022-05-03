// See https://aka.ms/new-console-template for more information
using Assign_08;

Console.WriteLine("Welcome to the Employee wage computation program");
//Class1.EmployeeAttendance();
//Class2.EmployeeWagesCal();
//Class3.PartTimeEmpWages();
//Class4.PartTimeUsingSwitch();
//Class5.WagesForMonth();
//Class6.TotalEmployeeWage();
//Class7.ComputeEmpWage();

//Class8.ComputeEmpWage("Dmart", 20, 2, 10);
//Class8.ComputeEmpWage("Reliance", 10, 4, 20);

//EmpWageBuilder Dmart = new EmpWageBuilder("Dmart", 20, 2, 10);
//EmpWageBuilder Reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
//Dmart.ComputeWage();
//Console.WriteLine(Dmart.ToString());
//Reliance.ComputeWage();
//Console.WriteLine(Reliance.ToString());

EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
empWageBuilder.ComputeEmpWage();

