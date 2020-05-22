namespace PrimeiraAtividadePOO
{
    public class SuperMan
    {
        public string nome;

        public string traje;

        public int dano_ao_traje;

        public float super_força(float força, float impulso)
        {
            return força * impulso;
        }

        public float laser(float raio, float temperatura)
        {
            return raio + temperatura;
        }

        public float invencibilidade(float resistência, float dano)
        {
            return resistência - dano;
        }

        public string Defender()
        {
            return "SuperMan deu um soco no Personagem de ...";
        }
        public string Atacar()
        {
            return "SuperMan jogou um laser de ";
        }

        public string Melhorar()
        {
            return "SuperMan é";
        }
        
        public string Melhorar2()
        {
            return "Obrigado :)";
        }
    }
}