using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    //This should set Type to GradeBookType.Standard

    public class StandardGradeBook : BaseGradeBook
    {
        
        public StandardGradeBook(string name, bool IsWeighted):base(name, IsWeighted)
        {
            Type= GradeBookType.Standard;
        }
    }


}