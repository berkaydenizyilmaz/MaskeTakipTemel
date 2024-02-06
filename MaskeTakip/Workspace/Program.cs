using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.firstName = "Berkay Deniz";
person1.lastName = "Yılmaz";
person1.nationalIdentity = 12345;
person1.dateOfBirthYear = 2003;

PTTManager pttManager = new PTTManager(new PersonManager());
pttManager.GiveMask(person1);