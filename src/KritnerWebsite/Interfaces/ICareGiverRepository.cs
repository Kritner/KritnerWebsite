using KritnerWebsite.Models.NewbornModels;

namespace KritnerWebsite.Interfaces
{
    public interface ICareGiverRepository
    {
        void CreateCareGiver(CareGiver careGiver);
        CareGiver GetUserInformation(string userName);
        void UpdateCareGiver(CareGiver careGiver);
    }
}