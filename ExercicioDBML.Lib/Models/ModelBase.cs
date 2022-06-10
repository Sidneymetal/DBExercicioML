namespace ExercicioDBML.Lib.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public ModelBase()
        {
            
        }
        public ModelBase(int id)
        {
            Id = id;
        }
    }
}