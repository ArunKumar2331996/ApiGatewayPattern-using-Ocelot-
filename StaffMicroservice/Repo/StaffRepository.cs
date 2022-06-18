using StaffMicroservice.Model;
using System.Collections.Generic;

namespace StaffMicroservice.Repo
{
    public class StaffRepository: IStaffRepository
    {
        public StaffRepository()
        {

        }

        public List<Staff> GetAllStaffs()
        {
            return StaffCollection();
        }

        private List<Staff> StaffCollection()
        {
            return new List<Staff>() { 
                new Staff() { StaffId =0, StaffName = "Arun", Desgination= "proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =1, StaffName = "Raj", Desgination= "asst proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =2, StaffName = "Kumar", Desgination= "junior proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =3, StaffName = "Vinoth", Desgination= "lecturer", PhoneNumber=00000000},
            new Staff() { StaffId =4, StaffName = "Rahul", Desgination= "proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =5, StaffName = "Gowtham", Desgination= "asst proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =6, StaffName = "Sam", Desgination= "junior proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =7, StaffName = "Raghu", Desgination= "HM", PhoneNumber=00000000},
            new Staff() { StaffId =8, StaffName = "Aruna", Desgination= "AHM", PhoneNumber=00000000},
            new Staff() { StaffId =9, StaffName = "Varun", Desgination= "AHM", PhoneNumber=00000000},
            new Staff() { StaffId =10, StaffName = "Tarun", Desgination= "proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =11, StaffName = "Karun", Desgination= "proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =12, StaffName = "Sharan", Desgination= "proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =13, StaffName = "Gopal", Desgination= "proffesor", PhoneNumber=00000000},
            new Staff() { StaffId =14, StaffName = "Chandh", Desgination= "proffesor", PhoneNumber=00000000}
            };
        }
    }

    public interface IStaffRepository
    {
        public List<Staff> GetAllStaffs();
    }
}

   

