using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1},
                new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2},
                new Category { Id = 3, Name = "Comedy", DisplayOrder = 3}
            );
            modelBuilder.Entity<Company>().HasData(

                new Company {
                    Id = 1,
                    Name = "Al Saeed Trading Co.",
                    StreetAddress = "Ans bin Malk road, Alsahafah",
                    City = "Riyadh",
                    State = "Riyadh",
                    PostalCode = "15448",
                    PhoneNumber = "0590502969",
                },
                new Company {
                    Id = 2,
                    Name = "Bin Abdulaziz Construction",
                    StreetAddress = "King Fahd road, Al Olaya",
                    City = "Riyadh",
                    State = "Riyadh",
                    PostalCode = "147826",
                    PhoneNumber = "0591234567",
                },
                new Company {
                    Id = 3,
                    Name = "Al Jazeera Electronics",
                    StreetAddress = "Prince Sultan road, Al Rawdah",
                    City = "Jeddah",
                    State = "Makkah",
                    PostalCode = "19856",
                    PhoneNumber = "0587654321",
                },
                new Company {
                    Id = 4,
                    Name = "Eastern Star Logistics",
                    StreetAddress = "Khalid bin Alwaleed street, Al Khobar",
                    City = "Dammam",
                    State = "Eastern Province",
                    PostalCode = "10254",
                    PhoneNumber = "0570987654",
                },
                new Company {
                    Id = 5,
                    Name = "Riyadh Medical Supplies",
                    StreetAddress = "Al Tahlia street, Al Sulaymaniyah",
                    City = "Riyadh",
                    State = "Riyadh",
                    PostalCode = "16720",
                    PhoneNumber = "0562345678",
                }
            );
            modelBuilder.Entity<Product>().HasData(

                new Product {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vita sodales libro some text here",
                    ISBN = "SWD99999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },

                new Product {
                    Id = 2,
                    Title = "The Dark Forest",
                    Author = "Liu Cixin",
                    Description = "A gripping sci-fi novel that explores the complexity of space and time.",
                    ISBN = "SWD99999002",
                    ListPrice = 120,
                    Price = 110,
                    Price50 = 105,
                    Price100 = 100,
                    CategoryId = 2,
                    ImageUrl = ""

                },

                new Product {
                    Id = 3,
                    Title = "The Silent Sea",
                    Author = "John Doe",
                    Description = "A thrilling adventure set in the depths of the ocean.",
                    ISBN = "SWD99999003",
                    ListPrice = 95,
                    Price = 85,
                    Price50 = 80,
                    Price100 = 75,
                    CategoryId = 3,
                    ImageUrl = ""

                },

                new Product {
                    Id = 4,
                    Title = "Journey to the West",
                    Author = "Wu Cheng'en",
                    Description = "An ancient Chinese tale of bravery, wisdom, and perseverance.",
                    ISBN = "SWD99999004",
                    ListPrice = 150,
                    Price = 140,
                    Price50 = 135,
                    Price100 = 130,
                    CategoryId = 2,
                    ImageUrl = ""

                },

                new Product {
                    Id = 5,
                    Title = "Mind Over Matter",
                    Author = "Jane Smith",
                    Description = "A deep dive into the science of the human mind and potential.",
                    ISBN = "SWD99999005",
                    ListPrice = 85,
                    Price = 80,
                    Price50 = 75,
                    Price100 = 70,
                    CategoryId = 1,
                    ImageUrl = ""

                },

                new Product {
                    Id = 6,
                    Title = "Secrets of the Cosmos",
                    Author = "Carl Sagan",
                    Description = "An exploration of the universe and its profound mysteries.",
                    ISBN = "SWD99999006",
                    ListPrice = 110,
                    Price = 100,
                    Price50 = 95,
                    Price100 = 90,
                    CategoryId = 1,
                    ImageUrl = ""

                },

                new Product {
                    Id = 7,
                    Title = "The Art of War",
                    Author = "Sun Tzu",
                    Description = "An ancient Chinese military treatise on strategy and tactics.",
                    ISBN = "SWD99999007",
                    ListPrice = 75,
                    Price = 70,
                    Price50 = 65,
                    Price100 = 60,
                    CategoryId = 2,
                    ImageUrl = ""

                }
            );
        }
    }
}
