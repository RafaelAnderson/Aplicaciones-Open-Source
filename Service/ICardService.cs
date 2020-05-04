using PointFood.Dto;

namespace PointFood.Service
{
    public interface ICardService
    {
        CardDto Create(CardCreateDto model);
        void Update(int id, CardUpdateDto model);
        void Remove(int id);
    }
}
