namespace ApiToothPaste.Models
{
    public class ModelToothPaste
    {
        public ModelToothPaste(toothpaste paste)
        {
            id_toothpaste = paste.id_toothpaste;
            name_toothpaste = paste.name_toothpaste;
            abrasiveness_index = paste.abrasiveness_index;
            country_of_origin = paste.country_of_origin;
            volume = paste.volume;
            price = paste.price;
            Image = paste.Image;
        }
        public int id_toothpaste { get; set; }
        public string name_toothpaste { get; set; }
        public int abrasiveness_index { get; set; }
        public string country_of_origin { get; set; }
        public int volume { get; set; }
        public double price { get; set; }
        public string Image { get; set; }
    }
}