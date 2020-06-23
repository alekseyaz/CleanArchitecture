﻿namespace Ultra.Infrastructure.WebHost.Interfaces
{
    public interface ICurrentUserService
    {
        int Id { get; }
        bool IsAuthenticated { get; }
        string Email { get; }
    }
}
