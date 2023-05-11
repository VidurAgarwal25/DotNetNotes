using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TemplatedHtmlHelper.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public String Email { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}