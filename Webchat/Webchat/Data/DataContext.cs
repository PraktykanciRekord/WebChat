﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Webchat.Data
{
    public class DataContext : IdentityDbContext
    {

        public DataContext(DbContextOptions  options) : base(options){ }    

    }
}