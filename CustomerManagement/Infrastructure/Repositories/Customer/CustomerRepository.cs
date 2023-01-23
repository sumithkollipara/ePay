using CustomerManagement.Common.Models;
using Newtonsoft.Json;

namespace CustomerManagement.Infrastructure.Repositories.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _filePath;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<CustomerRepository> _logger;
        public CustomerRepository(IHttpContextAccessor httpContextAccessor, ILogger<CustomerRepository> logger)
        {
            // Server.MapPath("~/App_Data/");
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ePayCustomerData.json");
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }
        public SortedList<string, CustomerModel> Read()
        {
            try
            {
                return JsonConvert.DeserializeObject<SortedList<string, CustomerModel>>(File.ReadAllText(_filePath));

            }
            catch (Exception ex)
            {
                _logger.LogError($"Unable to read JSON file from {_filePath}");
            }
            return null;
        }

        public void Write(SortedList<string, CustomerModel> data)
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(data));
        }
    }

}
