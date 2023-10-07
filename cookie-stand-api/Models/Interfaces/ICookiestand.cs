namespace cookie_stand_api.Models.Interfaces
{
    public interface ICookiestand
    {
        Task<List<Cookiestand>> GetAll();
        Task<Cookiestand> GetById(int id);

        Task<Cookiestand> Post(Cookiestand cookiestand);

        Task<Cookiestand> Put(int id, Cookiestand cookiestand);
        Task Delete(int id);
        //Task UpdateHourlySales(int id, List<int> hourlySales);

    }
}
