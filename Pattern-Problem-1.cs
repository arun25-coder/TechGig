/* 
  You need to take an integer input and then draw the pattern according to it. 
  Say for example if you enter 5 then, the pattern should be like this.
    1 1 1 1 1
    2 2 2 2 2
    3 3 3 3 3
    4 4 4 4 4
    5 5 5 5 5
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=N;i++){
            string val="";
            for(int j=0;j<N;j++){
                val += Convert.ToString(i) + " ";
            }
            Console.WriteLine(val.Substring(0,val.Length-1));
        }
    }
}
