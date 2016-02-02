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
                new FunTypes{FunTypeName="Museum"},
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
                #region Emergency 
                new Utilities{Name="Emergency",Acronym="SOS",Address="R. Conselheiro L. Magalhães, 3800 Aveiro",PhoneNumber="112", Email="email@email.com", URLSite="http://www.inem.pt/", URLImg="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Emergency")},
                new Utilities{Name="Hospital Infante D. Pedro, EPE - Aveiro",Acronym="Hostipal",Address="Av. Artur Ravara, 3814-501 Aveiro",PhoneNumber="234378300", Email="sec-adm@chbv.min-saude.pt", URLSite="http://www.hidpedro.min-saude.pt", URLImg="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Emergency")},
                #endregion
                
                #region Transports 
                new Utilities{Name="Taxi",Acronym="Taxi",Address="Edifício C Coordenador Transportes Aveiro Esgueira, 3800 AVEIRO ",PhoneNumber="234385799",Email="N/A", URLSite="http://taxisaveiro.pt/pt", URLImg="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Transport")},
                new Utilities{Name="MoveAveiro",Acronym="Bus",Address="Rua Artur Almeida Eça, 3800-111 Aveiro",PhoneNumber="234380560",Email="moveaveiro@moveaveiro.pt", URLSite="http://www.moveaveiro.pt/",URLImg="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Transport")},
                new Utilities{Name="Buga",Acronym="Buga",Address="Praça do Mercado 2, 3800 Aveiro, Portugal",PhoneNumber="234380560",Email="N/A",URLSite="http://www.visitcentrodeportugal.com.pt/pt/bugas-bicicletas-gratuitas-de-aveiro/", URLImg="~/Images/buga.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Transport")},

                #endregion
                
                #region Police 
                new Utilities{Name="Policia de Segurança Pública",Acronym="PSP",Address="Praça Marquês de Pombal, 3810-133 Aveiro",PhoneNumber="234400290",Email="cpaveiro@psp", URLSite="http://www.psp.pt/",URLImg="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Police")},
                new Utilities{Name="Guarda Nacional Republicana",Acronym="GNR",Address="Rua de Sá, 3804-503 Aveiro",PhoneNumber="234378220",Email="ct.avr@gnr.pt", URLSite="http://www.gnr.pt", URLImg="N/A", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Police")},
               #endregion
                
                #region Rest 
                new Utilities{Name="Melia Ria Hotel",Acronym="MeliaRia",Address="Cais da Fonte Nova, Lote 5 3810-200 Aveiro",PhoneNumber="234401000",Email="melia.ria@meliaportugal.com", URLSite="http://www.meliaria.com/pt-pt/home-2.aspx?areaId=31", URLImg="~/Images/meliaria.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Rest"),  RestTypes = restTypes.SingleOrDefault(x=>x.RestTypeName=="Hotel")},
                new Utilities{Name="Royal Guesthouse",Acronym="RoyalGuesthouse",Address="Rua de São Sebastião Nº9, 3810-187 Aveiro",PhoneNumber="965895878",Email="ct.avr@gnr.pt", URLSite="https://www.facebook.com/Royal-Guesthouse-555307391240256/", URLImg="~/Images/av1.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Rest"),  RestTypes = restTypes.SingleOrDefault(x=>x.RestTypeName=="Hostel")},
                #endregion
                
                #region Food 
                new Utilities{Name="Salpoente",Acronym="Salpoente",Address="Cais de S.Roque 83, 3800-256, Aveiro 3800",PhoneNumber="915138619",Email="salpoente@salpoente.pt", URLSite="http://salpoente.pt/", URLImg="~/Images/salpoente1.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Food"),  FoodTypes = foodTypes.SingleOrDefault(x=>x.FoodTypeName=="Restaurant")},
                new Utilities{Name="Cais Madeirense",Acronym="Cais",Address="Sitio do Cais dos Botirões,nº31 Aveiro",PhoneNumber="929058482",Email="N/A", URLSite="https://www.facebook.com/caismadeirenseaveiro/", URLImg="~/Images/caisMadeirense.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Food"),  FoodTypes = foodTypes.SingleOrDefault(x=>x.FoodTypeName=="Restaurant")},
                new Utilities{Name="Alemão",Acronym="Alemao",Address="Rua 5 - Urb. da boa Hora - Praia da Vagueira 3840 GAFANHA BOA HORA, Portugal",PhoneNumber="234797465",Email="N/A", URLSite="https://www.facebook.com/pages/Restaurante-Ei-Alem%C3%A3o-/176621399065002", URLImg="~/Images/alemao1.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Food"),  FoodTypes = foodTypes.SingleOrDefault(x=>x.FoodTypeName=="Restaurant")},

                #endregion
                
                #region Fun 
                new Utilities{Name="Estação da Luz",Acronym="EstacaoLuz",Address="Rua direita, Quintas 3810 Aveiro",PhoneNumber="234943979",Email="porteirovirtual@estacaodaluz.pt", URLSite="https://www.facebook.com/estacaodaluz", URLImg="~/Images/estacaoLuz.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Bars & Pubs")},
                new Utilities{Name="Praia da Costa Nova",Acronym="CostaNova",Address="R. da Quinta do Cravo 17, Aveiro",PhoneNumber="N/A",Email="N/A",URLSite="N/A", URLImg="~/Images/costaNova1.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Beach")},
                new Utilities{Name="Viagem Moliceiro",Acronym="Moliceiro",Address="Jardim do Rossio, Aveiro ",PhoneNumber="969008687",Email="vivaaria@gmail.com",URLSite="http://www.vivaaria.com/category/moliceiros-2/na-cidade-de-aveiro/", URLImg="~/Images/viagemMoliceiro.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Outdoor activities")},
                new Utilities{Name="Salinas",Acronym="Salinas",Address="R. da Pega 69, 3810-164 Aveiro, Portugal",PhoneNumber="N/A",Email="N/A",URLSite="http://www.visitcentrodeportugal.com.pt/pt/as-salinas-de-aveiro/", URLImg="~/Images/salinas.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Outdoor activities")},
                new Utilities{Name="Farol da Barra",Acronym="Farol",Address="Largo do Farol, Praia da Barra 3830-753 Gafanha da Nazaré, Portugal",PhoneNumber="234369271",Email="N/A",URLSite="http://www.cm-ilhavo.pt/pages/910", URLImg="~/Images/farol.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Beach")},
                new Utilities{Name="Museu Maritimo de Ilhavo",Acronym="MuseuIlhavo",Address="Avenida Dr. Rocha Madahíl 3830-193 Ílhavo Portugal",PhoneNumber="234329990",Email="museuilhavo@cm-ilhavo.pt",URLSite="http://www.museumaritimo.cm-ilhavo.pt/", URLImg="~/Images/museuIlhavo.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Museum")},
                new Utilities{Name="Reserva Natural das Dunas de S. Jacinto",Acronym="ReservasSaoJacinto",Address="Reserva Natural das Dunas de S. Jacinto. 3800 Aveiro",PhoneNumber="234331282",Email="angelina.barbosa@icnf.pt",URLSite="http://www.icnf.pt/portal/ap/r-nat/rndsj", URLImg="~/Images/dunas1.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Fun"),  FunTypes = funTypes.SingleOrDefault(x=>x.FunTypeName=="Outdoor activities")},

                #endregion
                
                #region Events 
                new Utilities{Name="Event",Acronym="Rua dos Marnotos, 64 Aveiro, Portugal",Address="Rua dos Marnotos, 64 Aveiro, Portugal",PhoneNumber="234044500",Email="eventosaveiro@eventosaveiro.com", URLSite="http://www.eventosaveiro.com/", URLImg="~/Images/av1.jpg", UtilitiesTypes =  utilitiesTypes.SingleOrDefault(x=>x.UtilityTypeName=="Event"),  EventTypes = eventTypes.SingleOrDefault(x=>x.EventTypeName=="Exhibitions")}
                #endregion
            };

            utilities.ForEach(s => context.Utilities.Add(s));
            context.SaveChanges();
            #endregion

            #region IMAGES REPOSITORY
            var imagesRep = new List<ImagesRepository>
            {             
                #region Emergency
                #endregion

                #region Transports
                new ImagesRepository{URLImage="~/Images/buga.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Buga")},
                new ImagesRepository{URLImage="~/Images/buga1.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Buga")},
                #endregion

                #region Police
                #endregion

                #region Rest
                new ImagesRepository{URLImage="~/Images/meliaria.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="MeliaRia")},
                new ImagesRepository{URLImage="~/Images/meliaria1.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="MeliaRia")},
                new ImagesRepository{URLImage="~/Images/meliaria2.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="MeliaRia")},
                new ImagesRepository{URLImage="~/Images/hotel1.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="MeliaRia")},
                new ImagesRepository{URLImage="~/Images/royal.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="RoyalGuesthouse")},
                new ImagesRepository{URLImage="~/Images/royal2.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="RoyalGuesthouse")},
                new ImagesRepository{URLImage="~/Images/hostel1.png", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="RoyalGuesthouse")},
                #endregion

                #region Food
                new ImagesRepository{URLImage="~/Images/salpoente.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Salpoente")},
                new ImagesRepository{URLImage="~/Images/salpoente1.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Salpoente")},
                new ImagesRepository{URLImage="~/Images/caisMadeirense.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Cais")},
                new ImagesRepository{URLImage="~/Images/caisMadeirense2.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Cais")},
                new ImagesRepository{URLImage="~/Images/caisMadeirense3.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Cais")},
                new ImagesRepository{URLImage="~/Images/alemao1.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Alemao")},

                #endregion

                #region Fun
                new ImagesRepository{URLImage="~/Images/estacaoLuz.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="EstacaoLuz")},
                new ImagesRepository{URLImage="~/Images/estacaoLuz2.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="EstacaoLuz")},
                new ImagesRepository{URLImage="~/Images/costaNova1.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="CostaNova")},
                new ImagesRepository{URLImage="~/Images/costaNova2.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="CostaNova")},
                new ImagesRepository{URLImage="~/Images/viagemMoliceiro.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Moliceiro")},
                new ImagesRepository{URLImage="~/Images/salinas.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Salinas")},
                new ImagesRepository{URLImage="~/Images/farol.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="Farol")},
                new ImagesRepository{URLImage="~/Images/museuIlhavo.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="MuseuIlhavo")},
                new ImagesRepository{URLImage="~/Images/dunas.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="ReservasSaoJacinto")},
                new ImagesRepository{URLImage="~/Images/dunas1.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="ReservasSaoJacinto")},
                new ImagesRepository{URLImage="~/Images/dunas2.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="ReservasSaoJacinto")},
                new ImagesRepository{URLImage="~/Images/dunas3.jpg", Utilities = utilities.SingleOrDefault(x=>x.Acronym =="ReservasSaoJacinto")},
                #endregion

                #region Events
                #endregion

                
            };

            imagesRep.ForEach(s => context.ImagesRepository.Add(s));
            context.SaveChanges();
            #endregion

        }
    }
}
