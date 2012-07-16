namespace GameApp.WebRole.Migrations {
    using System;
    using System.Data.Entity.Migrations;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GameContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.CannedAnswers.AddOrUpdate(
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Does this person have ADD?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Is this person at the Boston startup weekend?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Is this person male?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Is this person female?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Does this person wear glasses?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Does this person play a sport?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Is this person musical?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Is this person wearing red?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Is this person wearing blue?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Does this person like to ask a ton of questions?" },
                new CannedAnswer { Id = Guid.NewGuid(), Question = "Does this person think they know everything?" }
            );

            context.Users.AddOrUpdate(

                new User { Email = "player1@player1.com", FirstName = "Player", Id = 1, LastName = "One" },
                new User { Email = "player2@player2.com", FirstName = "Player", Id = 2, LastName = "Two" }
                );

        }
    }
}
