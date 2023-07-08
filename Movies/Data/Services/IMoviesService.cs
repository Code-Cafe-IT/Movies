using Movies.Data.Base;
using Movies.Data.ViewModels;
using Movies.Models;
using System.Threading.Tasks;

namespace Movies.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        //Đoạn mã này định nghĩa một phương thức có tên là "GetNewMovieDropdownsVMValues" trả về một đối tượng kiểu "Task<NewMovieDropdownsVM>".
        //"Task" một tác vụ bất đồng bộ
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
