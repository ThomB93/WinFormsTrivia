using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTrivia
{
    public class RootObject
    {
        public int response_code { get; set; }
        public List<Result> results { get; set; }
    }
}
