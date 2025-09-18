using core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Dto_Resorses
{
    public class ReviewDto
    {
        public int Id { get; set; }

        public String location  { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        // רשימת קישורים או שמות קבצים
        public List<string> Images { get; set; } = new();
    }
}
