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
            #region UTILITIES TYPES
            var utilitiesTypes = new List<UtilitiesTypes>
            {
                new UtilitiesTypes{UtilityTypeName="Emergency"},
                new UtilitiesTypes{UtilityTypeName="Event"},
                new UtilitiesTypes{UtilityTypeName="Food"},
                new UtilitiesTypes{UtilityTypeName="Fun"},
                new UtilitiesTypes{UtilityTypeName="Police"},
                new UtilitiesTypes{UtilityTypeName="Rest"},
                new UtilitiesTypes{UtilityTypeName="Transport"}
            };

            utilitiesTypes.ForEach(s => context.UtilitiesTypes.Add(s));
            context.SaveChanges();
            #endregion 
            
            #region REST TYPES
            var restTypes = new List<RestTypes>
            {             
                new RestTypes{RestTypeName="Apartament"},
                new RestTypes{RestTypeName="B&B"},
                new RestTypes{RestTypeName="Hostel"},
                new RestTypes{RestTypeName="Hotel"},
                new RestTypes{RestTypeName="Particular"}
            };

            restTypes.ForEach(s => context.RestTypes.Add(s));
            context.SaveChanges();

            #endregion

            #region FOOD TYPES
            var foodTypes = new List<FoodTypes>
            {             
                new FoodTypes{FoodTypeName="Bakeries"},
                new FoodTypes{FoodTypeName="Ice Cream"},
                new FoodTypes{FoodTypeName="Restaurant"}
            };

            foodTypes.ForEach(s => context.FoodTypes.Add(s));
            context.SaveChanges();

            #endregion

            #region FUN TYPES
            var funTypes = new List<FunTypes>
            {             
                new FunTypes{FunTypeName="Bars & Pubs"},
                new FunTypes{FunTypeName="Beach"},
                new FunTypes{FunTypeName="Castles and Palaces"},
                new FunTypes{FunTypeName="Outdoor activities"},
                new FunTypes{FunTypeName="Market"},
                new FunTypes{FunTypeName="Museums"},
                new FunTypes{FunTypeName="Shooping"}
            };

            funTypes.ForEach(s => context.FunTypes.Add(s));
            context.SaveChanges();

            #endregion

            #region EVENT TYPES
            var eventTypes = new List<EventTypes>
            {             
                new EventTypes{EventTypeName="Concert"},
                new EventTypes{EventTypeName="Exhibitions"},
                new EventTypes{EventTypeName="Guided tours"}
            };

            eventTypes.ForEach(s => context.EventTypes.Add(s));
            context.SaveChanges();

            #endregion

            #region UTILITIES
            var utilities = new List<Utilities>
            { 
                new Utilities{Name="Emergency",Acronym="SOS",Address="N/A",PhoneNumber="112", Email="email@email.com", URLSite="http://www.inem.pt/", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Emergency")},
                new Utilities{Name="Hospital Infante D. Pedro, EPE - Aveiro",Acronym="Hostipal",Address="Av. Artur Ravara, 3814-501 Aveiro",PhoneNumber="234378300", Email="sec-adm@chbv.min-saude.pt", URLSite="http://www.hidpedro.min-saude.pt", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Emergency")},
                new Utilities{Name="Taxi",Acronym="Taxi",Address="Edifício C Coordenador Transportes Aveiro Esgueira, 3800 AVEIRO ",PhoneNumber="234385799",Email="N/A", URLSite="http://taxisaveiro.pt/pt", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Transport")},
                new Utilities{Name="MoveAveiro",Acronym="Bus",Address="Rua Artur Almeida Eça, 3800-111 Aveiro",PhoneNumber="234380560",Email="moveaveiro@moveaveiro.pt", URLSite="http://www.moveaveiro.pt/", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Transport")},
                new Utilities{Name="Policia de Segurança Pública",Acronym="PSP",Address="Praça Marquês de Pombal, 3810-133 Aveiro",PhoneNumber="234400290",Email="cpaveiro@psp", URLSite="http://www.psp.pt/", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Police")},
                new Utilities{Name="Guarda Nacional Republicana",Acronym="GNR",Address="Rua de Sá, 3804-503 Aveiro",PhoneNumber="234378220",Email="ct.avr@gnr.pt", URLSite="http://www.gnr.pt", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Police")},
                new Utilities{Name="Melia Ria Hotel",Acronym="N/A",Address="Cais da Fonte Nova, Lote 5 3810-200 Aveiro",PhoneNumber="234401000",Email="melia.ria@meliaportugal.com", URLSite="http://www.meliaria.com/pt-pt/home-2.aspx?areaId=31", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Rest"),  RestTypes = restTypes.SingleOrDefault(x=>x.RestTypeName=="Hotel")},
                new Utilities{Name="Royal Guesthouse",Acronym="N/A",Address="Rua de São Sebastião Nº9, 3810-187 Aveiro",PhoneNumber="965895878",Email="ct.avr@gnr.pt", URLSite="https://www.facebook.com/Royal-Guesthouse-555307391240256/", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Rest"),  RestTypes = restTypes.SingleOrDefault(x=>x.RestTypeName=="Hostel")},
                new Utilities{Name="Salpoente",Acronym="N/A",Address="Cais de S.Roque 83, 3800-256, Aveiro 3800",PhoneNumber="915138619",Email="salpoente@salpoente.pt", URLSite="http://salpoente.pt/", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Food"),  FoodTypes = foodTypes.SingleOrDefault(x=>x.FoodTypeName=="Restaurant")},
                new Utilities{Name="Cais Madeirense",Acronym="N/A",Address="Sitio do Cais dos Botirões,nº31 Aveiro",PhoneNumber="929058482",Email="N/A", URLSite="https://www.facebook.com/caismadeirenseaveiro/", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Food"),  FoodTypes = foodTypes.SingleOrDefault(x=>x.FoodTypeName=="Restaurant")},
                new Utilities{Name="Estação da Luz",Acronym="N/A",Address="Rua direita, Quintas 3810 Aveiro",PhoneNumber="234943979",Email="porteirovirtual@estacaodaluz.pt", URLSite="https://www.facebook.com/estacaodaluz", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Bars & Pubs")},
                new Utilities{Name="Praia da Costa Nova",Acronym="N/A",Address="R. da Quinta do Cravo 17, Aveiro",PhoneNumber="N/A",Email="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Beach")},
                new Utilities{Name="Event1",Acronym="N/A",Address="N/A",PhoneNumber="N/A",Email="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Event"),  EventTypes = eventTypes.SingleOrDefault(x=>x.EventTypeName=="Concert")},
                new Utilities{Name="Event2",Acronym="N/A",Address="N/A",PhoneNumber="N/A",Email="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Event"),  EventTypes = eventTypes.SingleOrDefault(x=>x.EventTypeName=="Exhibitions")}
            };

            utilities.ForEach(s => context.Utilities.Add(s));
            context.SaveChanges();
            #endregion
        }
    }
}
