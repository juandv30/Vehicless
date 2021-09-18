using Vehicles.Common.Modelss;

namespace Vehicless.API.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
