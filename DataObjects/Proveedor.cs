using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Proveedor{
        private String idProveedor;
        private String nameProveedor;
        private String businessNameProveedor;
        private String addressProveedor;
        private String phoneProveedor;


        public String getIDProveedor(){
            return idProveedor;
        }
        public void setIDProveedor(String idProveedor){
            this.idProveedor = idProveedor;
        }

        public String getNameProveedor()
        {
            return nameProveedor;
        }
        public void setNameProveedor(String nameProveedor)
        {
            this.nameProveedor = nameProveedor;
        }

        public String getBusinessNameProveedor()
        {
            return businessNameProveedor;
        }
        public void setBusinessNameProveedor(String businessNameProveedor)
        {
            this.businessNameProveedor = businessNameProveedor;
        }

        public String getAddressProveedor()
        {
            return addressProveedor;
        }
        public void setAddressProveedor(String addressProveedor)
        {
            this.addressProveedor = addressProveedor;
        }

        public String getPhoneProveedor()
        {
            return phoneProveedor;
        }
        public void setPhoneProveedor(String phoneProveedor)
        {
            this.phoneProveedor = phoneProveedor;
        }
    }
}
