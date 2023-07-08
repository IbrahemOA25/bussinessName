using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IBussinessOperation
    {
        public List<BussinessInformation> GetAllBussiness();
        public void AddNewBussiness(List<BussinessInformation> bussinessInformation);
        public void RemoveBussiness(int bussinessInformationId);
        public void UpdateBussiness(int bussinessInformationId);
    }
    public class BussinessOperationService : IBussinessOperation
    {
        public void AddNewBussiness(List<BussinessInformation> bussinessInformation)
        {
            throw new NotImplementedException();
        }

        public List<BussinessInformation> GetAllBuBussiness()
        {
            throw new NotImplementedException();
        }

        public List<BussinessInformation> GetAllBussiness()
        {
            throw new NotImplementedException();
        }

        public void RemoveBussiness(int bussinessInformationId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBussiness(int bussinessInformationId)
        {
            throw new NotImplementedException();
        }
    }
}
