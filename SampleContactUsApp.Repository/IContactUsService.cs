using SampleContactUsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleContactUsApp.Contracts
{
    public interface IContactUsService
    {
        void SaveData(ContactUsModel contactUsForm);
    }
}
