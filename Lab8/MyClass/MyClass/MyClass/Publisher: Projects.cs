﻿using System;
namespace MyClass
{
    public class Publisher
    {
            struct LicenseNumber
            {
                public int licenseNumber;
                public DateTime data; 
                public override string ToString()
                {
                    string s = String.Format("Лицензия N-{0} от {1} г.",
                    licenseNumber, data.Year);
                    return s;
                }
            }
            public string Name { get; set; }
            public string EmailAdress { get; set; }
            private LicenseNumber LinNumber;
            public Publisher(string name, string emailAdress, int lnumber,
            DateTime data)
            {
                Name = name;
                EmailAdress = emailAdress;
                LinNumber.licenseNumber = lnumber;
                LinNumber.data = data;
            }
            public override string ToString()
            {
                string s = String.Format("\n--Название: {0}, \n--Электронный адрес: {1},\n--{2}", Name, EmailAdress, LinNumber);
                return s;
        }
    }
}
