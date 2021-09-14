using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomClone.Data
{
    public class Conference
    {
        public int Id { get; set; }
        public string ConferenceName { get; set; }
        [MaxLength(4)]
        public string PinCode { get; set; }
        public Guid ConferenceId { get; set; }
    }
}
