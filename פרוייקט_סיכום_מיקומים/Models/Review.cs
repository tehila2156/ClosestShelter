using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class Review
    {
    public int Id { get; set; }
    public Address address { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string Images { get; set; } 

    }
}
