//McKenna Trussel
//Assignment 5

//No longer needed now that database is live and set up!


using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5_McKennaTrussel_BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookStoreDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookStoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = new decimal(9.95),
                        Pages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Classic",
                        Price = new decimal(14.58),
                        Pages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = new decimal(21.54),
                        Pages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMiddleName = "C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = new decimal(11.61),
                        Pages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = new decimal(13.33),
                        Pages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = new decimal(15.95),
                        Pages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = new decimal(14.99),
                        Pages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = new decimal(21.66),
                        Pages = 240
                    },


                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = new decimal(29.16),
                        Pages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thriller",
                        Price = new decimal(15.03),
                        Pages = 642
                    },

                    new Book
                    {
                        Title = "One Hundred Birds Taught Me to Fly",
                        AuthorFirstName = "Ashley",
                        AuthorMiddleName = "M.",
                        AuthorLastName = "Hoiland",
                        Publisher = "Living Faith",
                        ISBN = "978-0842529921",
                        Classification = "Fiction",
                        Category = "Religious",
                        Price = new decimal(20.97),
                        Pages = 211
                    },

                    new Book
                    {
                        Title = "How to Win Friends and Influence People",
                        AuthorFirstName = "Dale",
                        AuthorLastName = "Carnegie",
                        Publisher = "Pocket Books",
                        ISBN = "978-6710270304",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = new decimal(13.87),
                        Pages = 234
                    },

                    new Book
                    {
                        Title = "Girl, Wash Your Face",
                        AuthorFirstName = "Rachel",
                        AuthorLastName = "Hollis",
                        Publisher = "Nelson Books",
                        ISBN = "978-1400201662",
                        Classification = "Non-Fiction",
                        Category = "Autobiography",
                        Price = new decimal(24.17),
                        Pages = 215
                    }
                );

                context.SaveChanges();


            }

        }
    }
}
