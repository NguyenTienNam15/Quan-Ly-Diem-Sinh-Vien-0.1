using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class QuickSort
    {
        private static QuickSort instance;

        internal static QuickSort Instance 
        { 
            get { if (instance == null) Instance = new QuickSort() ; return QuickSort.instance; } 
            private set { instance = value; } 
        }

        private QuickSort() { }


    }
}
