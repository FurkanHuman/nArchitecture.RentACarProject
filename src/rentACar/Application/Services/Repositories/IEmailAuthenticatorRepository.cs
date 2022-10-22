﻿using Core.Persistence.Repositories;
using Core.Domain.Concrete.Security.Entities;

namespace Application.Services.Repositories;

public interface IEmailAuthenticatorRepository : IAsyncRepository<EmailAuthenticator>, IRepository<EmailAuthenticator>
{
}