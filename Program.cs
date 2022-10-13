using EmployeeWage4Program;
Console.WriteLine("Welcome To Employee Wage Computation Program");

EmployeeCheck obj = new EmployeeCheck();
obj.CheckEmployeeAttendance();

DailyEmployeeWage obj1 = new DailyEmployeeWage();
obj1.CheckDailyEmployeeWage();

PartTimeWage obj2 = new PartTimeWage();
obj2.CheckEmployeePartTimeWage();

SwitchCaseStatement obj3 = new SwitchCaseStatement();
obj3.CheckDailyEmpWage();

EmployeeMonthWages obj4 = new EmployeeMonthWages();
obj4.CheckEmployeeMonthlyWage();

EmployeeTotalWages obj5 = new EmployeeTotalWages();
obj5.CheckEmployeeMonth();

RefactoreEmployeeWage employee = new RefactoreEmployeeWage();
employee.CheckComputeEmployeeWage();

EmpWageMultipleCompany empWageMultipleCompany = new EmpWageMultipleCompany();
empWageMultipleCompany.computeEmpWage("DMart",20,2,10);
empWageMultipleCompany.computeEmpWage("Jio", 25, 5, 20);
