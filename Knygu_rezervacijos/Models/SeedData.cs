using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Knygu_rezervacijos.Data;
using System;
using System.Linq;

namespace Knygu_rezervacijos.Models
{
    public class SeedData
    {
        

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Knygu_rezervacijosContext(serviceProvider.GetRequiredService<DbContextOptions<Knygu_rezervacijosContext>>()))
            {
                // Look for any books.
                if (context.Knyga.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Knyga.AddRange(
                    new Knyga
                    { 
                        Pavadinimas = "Zelenskis",
                        Santrauka = "Zelenskis – pirmoji ir kol kas vienintelė Ukrainos prezidento biografija. Žinomas Ukrainos žurnalistas ir knygų autorius Serhijus Rudenka pasakoja apie skirtingus Volodymyro Zelenskio gyvenimo etapus, pradedant jo vaikyste Kryvyj Rihe ir baigiant 2022 metų Rusijos ir Ukrainos karu.",
                        ISBN = "9786090151952",
                        Nuotrauka = "https://thumb.knygos-static.lt/4V8wJO5JFGddD8fo2obnmTs47Vk=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/2693983/1657891553_zelenskis_1virselis_1.jpg",
                        PuslapiuSkaicius = 304,
                        Kiekis = 2
                    },

                     new Knyga
                     {
                         Pavadinimas = "Turtingas tėtis, vargšas tėtis",
                         Santrauka = "Puikiai pasaulyje pažįstamas asmeninių finansų valdymo guru Robert T. Kiyosaki savo tarptautinio pripažinimo sulaukusioje knygoje Turtingas tėtis, vargšas tėtis dalijasi asmenine patirtimi ir unikaliomis idėjomis grįstu modeliu. Tai esminiai prin­cipai, kurie pakeis ne tik sustabarėjusį požiūrį į pinigus, bet ir kiekvieno, siekiančio finansinės gerovės, gyvenimą.",
                         ISBN = "9786094372919",
                         Nuotrauka = "https://thumb.knygos-static.lt/zySdh2InbNNYmYpoDULuzdeHF-k=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/992105/1462889120_turtingastetis071z1.jpg",
                         PuslapiuSkaicius = 224,
                         Kiekis = 4
                     }
                     );
                context.SaveChanges();
            }
        }
    }
}
