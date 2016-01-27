namespace MyAveiro.Migrations
{
    using MyAveiro.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyAveiro.DAL.MyAveiroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "MyAveiro.DAL.MyAveiroContext";
        }

        protected override void Seed(MyAveiro.DAL.MyAveiroContext context)
        {
            var utilitiesTypes = new List<UtilitiesTypes>
            {
            new UtilitiesTypes{UtilityName="Emergency"},
            new UtilitiesTypes{UtilityName="Transports"},
            new UtilitiesTypes{UtilityName="Police"}
            };

            utilitiesTypes.ForEach(s => context.UtilitiesTypes.Add(s));
            context.SaveChanges();

            var utilities = new List<Utilities>
            { new Utilities{UtilityID = 1,CompleteName="Emergency",Acronym="INEM",PhoneNumber="000000000", AddressNumber="Rua Lourenço Peixeinho",Email="email@email.com", URLSite="www.ua.pt"},
            new Utilities{UtilityID = 1, CompleteName="Hospital",Acronym="Hostipal",PhoneNumber="000000000", AddressNumber="Rua Lourenço Peixeinho",Email="email@email.com", URLSite="www.ua.pt"},
            new Utilities{UtilityID = 2,CompleteName="Taxi",Acronym="Taxi",PhoneNumber="000000000", AddressNumber="Rua Lourenço Peixeinho",Email="email@email.com", URLSite="www.ua.pt"},
            new Utilities{UtilityID = 2, CompleteName="DriveBus",Acronym="Bus",PhoneNumber="000000000", AddressNumber="Rua Lourenço Peixeinho",Email="email@email.com", URLSite="www.ua.pt"},
             new Utilities{UtilityID = 3, CompleteName="PSP",Acronym="Hostipal",PhoneNumber="000000000", AddressNumber="Rua Lourenço Peixeinho",Email="email@email.com", URLSite="www.ua.pt"},
            new Utilities{UtilityID = 3,CompleteName="PJ",Acronym="Taxi",PhoneNumber="000000000", AddressNumber="Rua Lourenço Peixeinho",Email="email@email.com", URLSite="www.ua.pt"}
            };

            utilities.ForEach(s => context.Utilities.Add(s));
            context.SaveChanges();
        }
    }
}
