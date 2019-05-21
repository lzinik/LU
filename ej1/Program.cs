using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dir = new string[] {"n","s","n","s","n","s","n","s","n","s"};
            string[] dir1 = new string[] {"n","s","s","s","n","s","n","s"};

            isValid(dir);
            esValido(dir);
            Console.WriteLine(isValid(dir));
            Console.WriteLine(isValid(dir1));


            bool isValid (string[] recorrido){
                int x=0;
                int y=0;
                    for (int i=0; i<recorrido.Length; i++ ){
                            if( recorrido[i] == "n"){
                                x++;
                            }else if(recorrido[i]=="s"){
                                x--;
                            }else if(recorrido[i]=="w"){
                                y--;
                            }else if(recorrido[i]=="e"){
                                y++;
                            }
                    }
                    if ( (recorrido.Length == 10) && (x == 0) && (y == 0) ){
                       return true; 
                    }else{
                        return false;
                    }
            }



        }
    }
    
}
