using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjControlPersonal {
	public class Empleado {
		public string Codigo { get; set; }
		public string paterno { get; set; }
		public string materno { get; set; }
		public string nombres { get; set; }
		public DateTime fechaNac { get; set; }
		public DateTime fechaCon { get; set; }
	}
}
