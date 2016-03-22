using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHangAnh.DAL.Entities
{
    public class DetailFormEntity
    {
        public int idDetailForm { get; set; }
        public string fieldName { get; set; }
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string location { get; set; }
        public string idForm { get; set; }
        public DetailFormEntity() { }
        public DetailFormEntity(int id, string fielName, int coordinateX, int coordinateY, int width, int height, string location, string idForm)
        {
            this.idDetailForm = id;
            this.fieldName = fieldName;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.width = width;
            this.height = height;
            this.location = location;
            this.idForm = idForm;
        }
    }
}
