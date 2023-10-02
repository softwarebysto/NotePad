using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.APIModes
{
    public class GetNotesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Conent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }

    }
}
