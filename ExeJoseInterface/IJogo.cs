namespace ExeJoseInterface
{
    public interface IJogo
    {
        string Name { get; set; }
        string Genero { get; set; }

        string Origem { get; set; }

         void Pular(){}

         void Atacar(){}
    
         void Defender(){}

         void ProcurarItem(){}

         void Descansar(){}
    }
}