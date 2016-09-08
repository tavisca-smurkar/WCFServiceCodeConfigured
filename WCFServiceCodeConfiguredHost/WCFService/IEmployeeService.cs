using System.ServiceModel;
namespace WCFService
{
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        Employee GetEmployee(string id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }
}
