using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wman.Models
{
    public class TableOfWman
    {


        public int Id { get; set; }


        [Display(Name ="اسم النسوان ")]
        public String NameOfWman { get; set; }


        [Display(Name = "عمر النسوان ")]
        public int AgeOfWman { get; set; }

        //public int DepartmentId { get; set; }
    }

}
