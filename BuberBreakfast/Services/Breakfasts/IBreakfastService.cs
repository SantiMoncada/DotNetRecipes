namespace BuberBreakfast.Services.Breakfasts;
using BuberBreakfast.Models;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast request);
    Breakfast GetBreakfast(Guid id);
    void UpsertBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid id);
}