using FacillitatorAssistantApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FacillitatorAssistantApp.Data
{
    public class DatabaseQuery
    {
        readonly SQLiteAsyncConnection _database;
        public DatabaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }
        #region CRUD
        //Select o busqueda de informacion
        public Task<List<User>> GetUsers()
        {
            return _database.QueryAsync<User>("Select * From User");
        }
        //Insertar y Actualizar
        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }

        }
        //Eliminar
        public Task<int> DeleteUsetAsync (User user)
        {
            return _database.DeleteAsync(user);
        }
        #endregion
    }
}
