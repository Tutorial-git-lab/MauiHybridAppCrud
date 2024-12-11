using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridAppDemo11.Models
{
    public class StudentModel
    {
        [PrimaryKey,AutoIncrement]
        public int StudentId { get; set; }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Gender { get; set; } = default!;

        public string Email {  get; set; } = default!;

    }
}
