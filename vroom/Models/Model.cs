using System.ComponentModel.DataAnnotations.Schema;

namespace vroom.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public Make Make { get; set; }

        [ForeignKey("Make")]
        public int MakeFK { get; set; }
        //public int MakeID { get; set; }
    }
}
