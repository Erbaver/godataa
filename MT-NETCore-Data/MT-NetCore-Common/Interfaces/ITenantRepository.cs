﻿using System;
using System.Threading.Tasks;

namespace MT_NetCore_Common.Interfaces
{
    public interface ITenantRepository
    {
        #region Countries

        //Task<List<CountryModel>> GetAllCountries(int tenantId);
        //Task<CountryModel> GetCountry(string countryCode, int tenantId);

        #endregion

        #region Customers

        //Task<int> AddCustomer(CustomerModel customeModel, int tenantId);
        //Task<CustomerModel> GetCustomer(string email, int tenantId);

        #endregion

        #region EventSections

        //Task<List<EventSectionModel>> GetEventSections(int eventId, int tenantId);

        #endregion

        #region Events

        //Task<List<EventModel>> GetEventsForTenant(int tenantId);
        //Task<EventModel> GetEvent(int eventId, int tenantId);

        #endregion

        #region Sections

        //Task<List<SectionModel>> GetSections(List<int> sectionIds, int tenantId);
        //Task<SectionModel> GetSection(int sectionId, int tenantId);

        #endregion

        #region TicketPurchases

        //Task<int> AddTicketPurchase(TicketPurchaseModel ticketPurchaseModel, int tenantId);
        #endregion

        #region Tickets

        //Task<bool> AddTickets(List<TicketModel> ticketModel, int tenantId);
        //Task<int> GetTicketsSold(int sectionId, int eventId, int tenantId);

        #endregion

        #region Venues

        //Task<VenuesModel> GetVenueDetails(int tenantId);

        #endregion

        #region VenueTypes

        //Task<VenueTypeModel> GetVenueType(string venueType, int tenantId);

        #endregion

    }
}
