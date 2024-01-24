using System.ComponentModel.DataAnnotations;


namespace Jijon_ExamenP3.Modelos
{
    public class DogBreedM
    {
        [Key]
        public int IdDog { get; set; }
        public string BreedName { get; set; }
    }
}
