using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Materiales{

        private String idMaterial;
        private String nameMaterial;
        private String categoryMaterial;
        private String fechaIngresoMaterial;
        private String loteMaterial;
        private String fechaVencimientoMaterial;
        private String idProveedor;

        private int cantidadMaterial;


        public String getIDMaterial(){
            return idMaterial;
        }
        public void setIDMaterial(String idMaterial){
            this.idMaterial = idMaterial;
        }

        public String getNameMaterial()
        {
            return nameMaterial;
        }
        public void setNameMaterial(String nameMaterial)
        {
            this.nameMaterial = nameMaterial;
        }

        public String getCategoryMaterial()
        {
            return categoryMaterial;
        }
        public void setCategoryMaterial(String categoryMaterial)
        {
            this.categoryMaterial = categoryMaterial;
        }

        public String getFechaIngresoMaterial()
        {
            return fechaIngresoMaterial;
        }
        public void setFechaIngresoMaterial(String fechaIngresoMaterial)
        {
            this.fechaIngresoMaterial = fechaIngresoMaterial;
        }

        public String getLoteMaterial()
        {
            return loteMaterial;
        }
        public void setLoteMaterial(String loteMaterial)
        {
            this.loteMaterial = loteMaterial;
        }

        public String getFechaVencimientoMaterial()
        {
            return fechaVencimientoMaterial;
        }
        public void setFechaVencimientoMaterial(String fechaVencimientoMaterial)
        {
            this.fechaVencimientoMaterial = fechaVencimientoMaterial;
        }

        public String getIDProveedor()
        {
            return idProveedor;
        }
        public void setIDProveedor(String idProveedor)
        {
            this.idProveedor = idProveedor;
        }

        public int getCantidadMaterial()
        {
            return cantidadMaterial;
        }
        public void setCantidadMaterial(int cantidadMaterial)
        {
            this.cantidadMaterial = cantidadMaterial;
        }
    }
}
