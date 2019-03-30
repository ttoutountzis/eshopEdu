using Models.Abstruct_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class User : BaseProps
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public int GetSomething(int num)
        {
            num = num + 1;
            return num;
        }
    }
}
