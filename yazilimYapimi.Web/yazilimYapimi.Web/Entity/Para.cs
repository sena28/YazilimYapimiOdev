using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace yazilimYapimi.Web.Entity
{
    public class Para
    {
        public int ParaId { get; set; }
        public int KullaniciId { get; set; }
        public double ParaMiktar { get; set; }
        public bool ParaOnay { get; set; }
    }
}