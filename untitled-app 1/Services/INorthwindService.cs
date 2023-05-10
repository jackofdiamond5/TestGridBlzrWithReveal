namespace untitled_app_1.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();
    }
}