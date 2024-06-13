namespace TestDemo;

public static class Algorithm
{
    public static string cifrado(string input,int k){

    string mensajeOriginal = input;

    char[] characters = new char[27] {'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

    int result = 0;
    string newString =""; //Nuestro mensaje cifrado se guardara aqui

for(int i = 0; i < mensajeOriginal.Length; ++i){  //Iteramos en el mensaje original

    for(int j = 0; j < characters.Length; ++j){ //Iteramos en los elementos del ABC
        char checker = mensajeOriginal[i];

        if(checker == characters[j]){ //Chequeamos si el caracter i del mensaje original es igual al ABC  

            result = (j + k) % characters.Length;
    
            while(result > characters.Length){              //Verificamos si no excede de los valores de la matriz
                result = result - characters.Length ;
            }
    
            newString += characters[result];
            
                }

            }
        }
        return newString;
    }

    public static string descifrado(string input, int t){

        char[] characters = new char[27] { 'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        string cifrada = input; //nuestra palabra a cifrada a decifrar
        string descifrado = ""; //Aqui guardaremos nuestra palabra decifrada
        int result = 0;

        for(int i = 0; i < cifrada.Length; ++i){
            for(int j = 0; j < characters.Length; ++j){
                char checker = cifrada[i];
                if(checker == characters[j]){
                    result = j - t;
                    while(result < 0){
                            result = result + characters.Length ;
                        }

                    descifrado += characters[result];
                    
                }
            }
        }


        return descifrado;

    }


}
