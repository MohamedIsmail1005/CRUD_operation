namespace GameZone.Services
{
    public interface IGamesService
    {
        IEnumerable<Game> GetAll();

        Game? GetbyId(int id);
        Task Create(CreateFormViewModel model);

        Task<Game?> Edit(EditFormViewModel model);

        bool Delete(int id);
    }
}
