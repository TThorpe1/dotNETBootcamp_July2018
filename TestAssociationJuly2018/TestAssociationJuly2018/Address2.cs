using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssociationJuly2018
{
    partial class Address
    {
        public Address(string strNo, string zip, string strName)
        {
            StreetNo = strNo;
            ZipCode = zip;
            StreetName = strName;
        }
    }
}
