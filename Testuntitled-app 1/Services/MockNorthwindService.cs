namespace untitled_app_1.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }
    }
}