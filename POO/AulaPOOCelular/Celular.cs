namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public double tamanho;

        public bool ligado = false;

        public bool Ligar(){
            ligado = true;
            return ligado;
        }
        public bool Desligar(){
            ligado = false;
            return ligado;
        }

        
        
        public string Fazerligacao(string destinatario){
            string chamando = $@"
            __________________________________
            |        {modelo}     | 
            |                                |
            |                                |
            |                                |
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |        {destinatario}             | 
            |             não                | 
            |           atendeu              | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |________________________________|";
            return chamando;
        }

        public string MandarMensagem(string destinatario, string mensagem){
            string enviado = $@"
            __________________________________
            |        {modelo}     | 
            |________________________________|
            |{destinatario}                  |
            |________________________________|
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |             ___________________| 
            |            |                   | 
            |            | {mensagem}        | 
            |            |___________________| 
            |                                | 
            |                                | 
            |                                | 
            |________________________________|";;
            return enviado;
        }


    }
}