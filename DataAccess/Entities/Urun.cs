using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
	public class Urun : IEntity
	{
		[Key]
		public int UrunID { get; set; }
		public string UrunAdi { get; set; }
		public int TedarikciID { get; set; }
		public int KategoriID { get; set; }
		public string Barkod { get; set; }
		public decimal BirimFiyati { get; set; }
		public short HedefStokDuzeyi { get; set; }
		public short YeniSatis { get; set; }
		public short EnAzYenidenSatisMikatari { get; set; }
		public string GorselUrl { get; set; }
		public bool Sonlandi { get; set; }
		public decimal? EskiSatisFiyati { get; set; }
	}
}
