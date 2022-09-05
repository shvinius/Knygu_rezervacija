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
                     },

                     new Knyga
                     {
                         Pavadinimas = "Gyvulių ūkis",
                         Santrauka = "„Pasakojimas apie revoliuciją, pasukusią šunkeliais — ir apie tai, kaip puikiai buvo pateisinamas kiekvienas būsimas jos pradinės doktrinos iškraipymo žingsnis\", — rašė Orvelas pratarmėje pirmajam „Gyvulių ūkio\" leidimui 1945 metais. Šį romaną Orvelas sukūrė 1943-iųjų pabaigoje, bet knyga galėjo likti neišspausdinta. Dėl to, kad joje buvo įnirtingai puolamas Stalinas, leidėjai vienas po kito atsisakydavo knygos. Orvelo paprasta, tragikomiška pasakėčia apie tai, kas nutinka gyvuliams išvijus poną Džonsą ir mėginant tvarkytis ūkyje patiems — neblėstanti pasaulinio garso klasika.",
                         ISBN = "9789955137610",
                         Nuotrauka = "https://thumb.knygos-static.lt/kmAWx0glHvvVUn2VFGW0Gs5AMN8=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/1169108/1533286659_gyvuliu-ukis-2018.jpg",
                         PuslapiuSkaicius = 136,
                         Kiekis = 8
                     },
                     new Knyga
                     {
                         Pavadinimas = "Neribota atmintis",
                         Santrauka = "Skaitydamas šį vadovą sužinosite, kaip paaštrinti protą, lavinti atmintį ir protinius gebėjimus. Išsiaiškinsite, kaip ugdyti įgūdžius, padedančius įsiminti itin daug informacijos ir kontroliuoti savo verslą bei visą gyvenimą.",
                         ISBN = "9786098194043",
                         Nuotrauka = "https://thumb.knygos-static.lt/7gNdt7OamW9gtsp9N_ht7TtS3SA=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/1162923/1518700215_Neribota-Atmintis-priekinis-virselis.png",
                         PuslapiuSkaicius = 144,
                         Kiekis = 3
                     },
                     new Knyga
                     {
                         Pavadinimas = "Atominiai įpročiai",
                         Santrauka = "Nesvarbu, kokie jūsų tikslai, „Atominiuose įpročiuose\" rasite patikrintą sistemą, kuri leis kasdien tobulėti. Džeimsas Kliras (James Clear), vienas iš geriausių įpročių formavimo specialistų pasaulyje, šioje knygoje pristato praktinius būdus, padėsiančius išsiugdyti gerus įpročius, nugalėti blogus ir palengva žingsniuojant pasiekti įspūdingų rezultatų.",
                         ISBN = "9786098254037",
                         Nuotrauka = "https://thumb.knygos-static.lt/RX--C02sklI7XyeOF0ketxcShnQ=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/1446279/1561552643_Atominiai-iprociai-virselis-liutai-priekis-JPG_geras.jpg",
                         PuslapiuSkaicius = 320,
                         Kiekis = 1
                     },
                     new Knyga
                     {
                         Pavadinimas = "Altorių šešėly",
                         Santrauka = "„Altorių šešėly“ – svarbiausias lietuvių literatūros klasiko Vinco Mykolaičio-Putino kūrinys. Šis psichologinis romanas ypač svarbus XX a. ketvirtojo dešimtmečio literatūros kontekste, nes puikiai atskleidžia filosofinį pagrindinio veikėjo santykį su gyvenamuoju laiku. Altorių šešėly pradėjo naują kelią lietuvių romano istorijoje ir iki šiol tebelaikomas geriausiu psichologiniu romanu lietuvių literatūroje.",
                         ISBN = "9789955237907",
                         Nuotrauka = "https://thumb.knygos-static.lt/BkYKfT32Y7Fa9BOtJBYWQaikjSA=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/744081/1462885400_vmpaltoriusesely72max.jpg",
                         PuslapiuSkaicius = 716,
                         Kiekis = 5
                     },
                     new Knyga
                     {
                         Pavadinimas = "Vertybinių popierių analizė",
                         Santrauka = "Benjamino Grahamo ir Davido Doddo knyga „Vertybinių popierių analizė\" visiems laikams pakeitė investavimo teoriją ir praktiką. Parašyta daugiau nei prieš 80 m. ši knyga iki šiol laikoma vertės investavimo biblija.",
                         ISBN = "9786098013351",
                         Nuotrauka = "https://thumb.knygos-static.lt/ZKVP0o-ZCH0dVe_RtpKxeXVVObM=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/974262/1462888387_cdb9786098013351z1.jpg",
                         PuslapiuSkaicius = 712,
                         Kiekis = 2
                     },
                     new Knyga
                     {
                         Pavadinimas = "Elonas Muskas: „Tesla“, „SpaceX“ ir fantastinės ateities paieškos",
                         Santrauka = "E. Musko sukurta bendrovė „SpaceX\" nuskraidino atsargų kapsulę į Tarptautinę kosminę stotį ir saugiai sugrąžino ją atgal į Žemę. Tai privertė nutilti Elono atžvilgiu skeptiškiausiai nusiteikusius mokslininkus net ginčuose apie, regis, utopišką jo idėją – Marso apgyvendinimą. Kita jo bendrovė, „Tesla Motors\", sukūrė „Model S\", o vėliau – ir visureigį „Model X\" – išskirtinius elektra varomus automobilius, atėmusius amą visai automobilių pramonei. Ir tai − dar ne viskas. E. Muskas yra sparčiai augančios saulės energetikos įmonės „Solar City\" įkūrėjas.",
                         ISBN = "9786094373350",
                         Nuotrauka = "https://thumb.knygos-static.lt/J7GRoK7Dy_LipJPhzAH45KbsYf8=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/1128030/1476697644_ELON_MUSK__Greit_5800caff14052.jpg",
                         PuslapiuSkaicius = 348,
                         Kiekis = 1
                     },
                     new Knyga
                     {
                         Pavadinimas = "Kriptovaliutos: lengvas būdas praturtėti – visi esminiai klausimai ir atsakymai",
                         Santrauka = "Viskas, ką reikia žinoti apie KRIPTOVALIUTAS ir blokų grandinių (blockchain) technologiją – vienoje knygoje! Susipažinkite su pasaulio finansų ateitimi, kuri jau šiandien milijonus žmonių pavertė turtingais, o netolimoje ateityje iš esmės sukrės pasaulio pinigų dėsnius, šalių ekonomikas ir kiekvieno iš mūsų asmeninius finansus.",
                         ISBN = "9786094844416",
                         Nuotrauka = "https://thumb.knygos-static.lt/QK7duNQmt6B_G0AmGZtUBZp2ryM=/fit-in/0x800/filters:cwatermark(static/wm.png,500,75,30)/images/books/2669051/1645778887_Lengvas_budas_praturteti_kriptovaliutos_virselis_obuolys_LT_01-1.jpg",
                         PuslapiuSkaicius = 352,
                         Kiekis = 12
                     }
                     );
                context.SaveChanges();
            }
        }
    }
}
