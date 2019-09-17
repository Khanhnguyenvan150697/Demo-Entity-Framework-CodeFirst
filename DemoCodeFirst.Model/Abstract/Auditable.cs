using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public string CreatedBy { set; get; }

        [MaxLength(256)]
        public DateTime? UpdatedDate { set; get; }

        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
