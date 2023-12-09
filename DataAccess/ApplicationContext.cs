// <copyright file="ApplicationContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DataAccess;

using Entities;
using Microsoft.EntityFrameworkCore;

internal class ApplicationContext : DbContext
{
    public DbSet<Game> Games { get; set; } = null!;

    public ApplicationContext()
    {
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = games.db");
    }

}
