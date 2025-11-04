// File: Services/SessionState.cs
using AppraisalAppV1.Models;

namespace AppraisalAppV1.Services
{
    public class SessionState
    {
        public User? CurrentUser { get; private set; }

        public bool IsLoggedIn => CurrentUser != null;

        // 👈 Add this event
        public event Action? OnChange;

        public void Login(User user)
        {
            CurrentUser = user;
            NotifyStateChanged(); // 👈 Notify on change
        }

        public void Logout()
        {
            CurrentUser = null;
            NotifyStateChanged(); // 👈 Notify on change
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
