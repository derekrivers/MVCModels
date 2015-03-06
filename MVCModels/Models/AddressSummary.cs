using System.Web.Mvc;
using MVCModels.Infrastructure;

namespace MVCModels.Models
{

    [ModelBinder(typeof(AddressSummaryBinder))]
    public class AddressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}