using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class BtwStatAcc
    {
        [Key]
        public int id { get; set; }
        public State State { get; set; }
        public Acceptance Acceptance { get; set; }

    }
}
