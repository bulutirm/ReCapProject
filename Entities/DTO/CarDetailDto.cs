using Core.Entities;

namespace Entities.DTO
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public int  ColorId { get; set; }

        public string ColorName { get; set; }

        public string BrandName { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ModelYear { get; set; }

        public int DailyPrice { get; set; }
    }
}
