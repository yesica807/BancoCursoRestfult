using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cliente : AuditableBaseEntity
    {
        private int _edad;

        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string Email { get; set; }
        public required string Direccion { get; set;  }
        public int Edad
        {
            get
            {
                if(this._edad <= 0)
                {
                    this._edad = new DateTime(DateTime.Now.Subtract(this.FechaNacimiento).Ticks).Year - 1;
                }
                return this._edad;
            }
        }
    }
}
