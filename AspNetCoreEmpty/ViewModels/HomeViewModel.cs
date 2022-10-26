using AspNetCoreEmpty.Models;

namespace AspNetCoreEmpty.ViewModels
{
    internal class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}