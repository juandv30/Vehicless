using System;
using System.Threading.Tasks;
using Vehicless.API.Data.Entities;
using Vehicless.API.Models;

namespace Vehicless.API.Helpers
{
    public interface IConverterHelper
    {
        Task<User> ToUserAsync(UserViewModel model, Guid imageId, bool isNew);

        UserViewModel ToUserViewModel(User user);
    }
}
