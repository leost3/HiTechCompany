using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.Business;

namespace HiTech.Business
{
    public class Book
    {
        public int Isbn { get; set; }
        private string title;
        public string Title { get => title; set => title = value; }
        
    }  
}
