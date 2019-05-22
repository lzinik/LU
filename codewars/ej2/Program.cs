using System;
using System.Globalization;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(XO("asdasxasdasdoasdasdXxasdasdoO0asdx"));
            Console.WriteLine(XO("xxoO"));
            bool XO(string input){
                
                bool res = false;

                int x=0;
            
                for(int i=0; i< input.Length; i++ ){
                    if(Char.ToLower(input[i]) == 'o'){
                        x++;
                    } else if(Char.ToLower(input[i]) == 'x'){
                    
                        x--;                
                    }
                }
                
                if(x==0){
                    res = true;
                }
                return res;
            }
        }
    }
}
