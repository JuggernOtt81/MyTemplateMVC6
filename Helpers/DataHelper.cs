﻿using MyTemplateMVC6.Data;
using Microsoft.EntityFrameworkCore;

namespace MyTemplateMVC6.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            //Service: An instance of db context
            ApplicationDbContext dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();

            //Migration: This is the programmatic equivalent to Update-Database
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
