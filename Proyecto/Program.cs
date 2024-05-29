using TestDemo;

Console.WriteLine("Ingrese la palabra a decifrar: ");
string mensaje = Console.ReadLine(); //palabra ingresada por el usuario
string mensajeOriginal = ""; //Palabra que ingreso el usuario pero limpiada de caracteres y todas en mayusculas.

for(int i = 0; i < mensaje.Length; ++i){
    char depurador = mensaje[i];
    int iterador = depurador;
    if(iterador > 64 && iterador < 91 || iterador > 97 && iterador < 123 ){
        mensajeOriginal += mensaje[i];
    }
}

Console.WriteLine("Tu palabra limpia y lista para ser cifrada es:" + mensajeOriginal);
Console.WriteLine("Ingrese la Clave (valores numericos) Debe recordar la clave para volver a decifrar el mensaje");
int k = int.Parse(Console.ReadLine());
string cifrado1 = Algorithm.cifrado(mensajeOriginal, k);
Console.WriteLine("la palabra cifrada es:" + cifrado1); 

Console.WriteLine("-------------------------------------------------------");
 
string decifrada = Algorithm.descifrado(cifrado1,k);
Console.WriteLine("Su palabra decifrada es:" + decifrada);