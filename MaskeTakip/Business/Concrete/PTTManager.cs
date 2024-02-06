using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PTTManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PTTManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine($"{person.firstName} isimli kişiye maske verildi.");
        }
        else
        {
            Console.WriteLine("Kişinin kimlik bilgileri hatalı.");
        }
    }
}