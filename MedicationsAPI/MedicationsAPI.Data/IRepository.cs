using MedicationsAPI.Models;

namespace MedicationsAPI.Data
{
    public interface IRepository
    {
        Task<IEnumerable<Medicines>> GetAllMedicinesAsync();


    }
}