using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;

var db = new SlidDbContext();
db.Database.Migrate();
