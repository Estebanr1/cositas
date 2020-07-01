using System;

namespace UsuarioContrasenia
{
    class Program
    {   static    string[] usuario = new string[5];
        static string[] contrasenia = new string[5];
        static string newUser = new string("");
        static string newPass = new string("");

        static void Main(string[] args)
        {


            Console.WriteLine("hola");

            setUser();
            setPass();
            ingresarUser();
            corroboraUser();
            corroboraPass();


        }
        
        static void setUser()
        {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingresar nombre de Usuario " + i);
                    usuario[i] = Console.ReadLine();
                }
        }
        
        static void setPass()
        {
                for (int i = 0; i < contrasenia.Length; i++)
                {
                    Console.WriteLine("Ingrese contraseña " + i);
                    contrasenia[i] = Console.ReadLine();
                }
        }
        
        static void ingresarUser()
        {
                Console.WriteLine("Ahora ingrese usuario cargado");
                newUser = Console.ReadLine();
        }
        
        static void ingresaPass()
        {
                Console.WriteLine("Ingrese contraseña");
                newPass = Console.ReadLine();
        }
        
        static void corroboraUser()
        {
                if (newUser == usuario[0]) ingresaPass();

                else if (newUser == usuario[1]) ingresaPass();

                else if (newUser == usuario[2]) ingresaPass();

                else if (newUser == usuario[3]) ingresaPass();

                else if (newUser == usuario[4]) ingresaPass();

                else Console.WriteLine("usuario incorrecto");
        }
        
        static void corroboraPass()
        {
            if (newPass == contrasenia[0]) ;

            else if (newPass == contrasenia[1]) todoOk();
            else if (newPass == contrasenia[2]) todoOk();
            else if (newPass == contrasenia[3]) todoOk();
            else if (newPass == contrasenia[4]) todoOk();
                        
        }
        static void todoOk()
        { Console.WriteLine("CONGRATULATIONS"); }





        
    }
}



