﻿using Microsoft.EntityFrameworkCore;
using Server.DAL.Context;
using Server.Models;

namespace Server.DAL.DAOs
{
    public class StatusDao
    {
        private readonly IAppDbContext dbContext;

        public StatusDao(IAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<StatusModel> GetAll()
        {
            return dbContext.StatusTypes.AsNoTracking().ToList();
        }
    }
}