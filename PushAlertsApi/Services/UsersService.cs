﻿using Microsoft.EntityFrameworkCore;
using PushAlertsApi.Models;

namespace PushAlertsApi.Services
{
    public class UsersService : IUsersService
    {
        private readonly ILogger<UsersService> _logger;

        private readonly DbSet<User> _dbSet;

        public UsersService(DbSet<User> context)
        {
            _logger = new LoggerFactory().CreateLogger<UsersService>();
            _dbSet = context;
        }

        public User GetUser(string uuid)
        {
            var user = _dbSet.First(u => u.Uuid == Guid.Parse(uuid));
            _logger.LogInformation($"Fetched user from database with uuid: '{uuid}'.");
            return user;
        }
    }
}