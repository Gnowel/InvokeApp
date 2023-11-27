using InvokeApp.Shared.Enums;

namespace InvokeApp.Shared.DTOs
{
    public class FilterDto
    {
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int Сategory { get; set; }
        public Sorting Sorting { get; set; }

        public FilterDto() 
        {
            Sorting = Sorting.New;
        }
    }
}
