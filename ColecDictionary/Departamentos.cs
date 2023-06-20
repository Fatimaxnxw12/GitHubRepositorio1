namespace Departamentos
{
    public class Depto
    {
        public string Name { get; set; }
        public int population { get; set; }

        public Depto(string n, int poblacion)
        {
            Name = n;
            population = poblacion;
        }
    }
}
