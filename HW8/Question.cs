using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Question
    {
        public String Title { get; set; }
        public String Description { get; set; }

        public String Variant0 { get; set; }
        public String Variant1 { get; set; }
        public String Variant2 { get; set; }
        public String Variant3 { get; set; }

        public int CorrectVariant { get; set; }

        public Question()
        { 
        
        }
        public Question(
            String _Title, 
            String _Description, 
            String _Variant0,
            String _Variant1,
            String _Variant2,
            String _Variant3,
            int _CorrectVariant)
        {
            Title = _Title;
            Description = _Description;
            Variant0 = _Variant0;
            Variant1 = _Variant1;
            Variant2 = _Variant2;
            Variant3 = _Variant3;
            CorrectVariant = _CorrectVariant;
        }
    }


}
