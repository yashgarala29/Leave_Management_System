using Leave_Management_System.Models.ViewModel;
using System.Threading.Tasks;

namespace Leave_Management_System.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmail userEmail);
        Task SendLeaveCancelEmail(UserEmail userEmail);
        Task SendLeaveUpdateEmail(UserEmail userEmail);
    }
}