using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo",
                ISBN = "978-1-85-326733-8",
                desc = "A classic book!",
                publishedYear = 1998
            };

            Book yellowKing = new Book()
            {
                Title = "The King in Yellow",
                ISBN = "978-1-55-742368-9",
                desc = "Cosmic horror",
                publishedYear = 2005
            };

            Book threeStigmata = new Book()
            {
                Title = "The Three Stigmata of Palmer Eldritch",
                ISBN = "978-0-54-757255-0",
                desc = "A psychedelic odyssey of hallucinations-within-hallucinations from which no reader emerges unscathed.",
                publishedYear = 2011
            };

            Book valis = new Book()
            {
                Title = "VALIS",
                ISBN = "978-0-54-757241-3",
                desc = "Dick is one of the ten best American writers of the twentieth century, which is saying a lot. Dick was a kind of Kafka steeped in LSD and rage.",
                publishedYear = 2011
            };

            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };

            Author bobChambers = new Author()
            {
                Name = "Robert W. Chambers"
            };

            Author horseLoverFat = new Author()
            {
                Name = "Philip K. Dick"
            };

            Member dCorson= new Member(6306097773, "Dean Corson");
            Member hWest = new Member(8103142199, "Herbet West");
            Loan hwYelLoan = new Loan();
            Loan dcMontLoan = new Loan();
            Loan dcVaLoan = new Loan();
            Loan dcThreeLoan = new Loan();

            alexDumas.Books.Add(monteCristo);
            monteCristo.AddCopy();
            bobChambers.Books.Add(yellowKing);
            yellowKing.AddCopy();
            horseLoverFat.Books.Add(threeStigmata);
            horseLoverFat.Books.Add(valis);
            monteCristo.author = alexDumas;
            yellowKing.author = bobChambers;
            threeStigmata.author = horseLoverFat;
            valis.author = horseLoverFat;
            hwYelLoan.DoALoan(yellowKing, hWest);
            dcMontLoan.DoALoan(monteCristo, dCorson);
            dcMontLoan.time = DateTime.Today.AddDays(-27);
            dcMontLoan.dueDate = DateTime.Today.AddDays(-12);
            dcMontLoan.Return();
            dcVaLoan.DoALoan(valis, dCorson);
            dcThreeLoan.DoSpecLoan(threeStigmata.copies.First(), dCorson);
            dcThreeLoan.time = DateTime.Today.AddDays(-19);
            dcThreeLoan.dueDate = DateTime.Today.AddDays(-4);

            context.Books.Add(monteCristo);
            context.Books.Add(yellowKing);
            context.Books.Add(threeStigmata);
            context.Books.Add(valis);
            context.Authors.Add(bobChambers);
            context.Authors.Add(alexDumas);
            context.Authors.Add(horseLoverFat);
            context.Members.Add(dCorson);
            context.Members.Add(hWest);
            context.Loans.Add(hwYelLoan);
            context.Loans.Add(dcMontLoan);
            context.Loans.Add(dcVaLoan);
            context.Loans.Add(dcThreeLoan);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
