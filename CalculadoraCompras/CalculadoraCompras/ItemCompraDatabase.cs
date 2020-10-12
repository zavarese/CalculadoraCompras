using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace CalculadoraCompras
{
    class ItemCompraDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ItemCompraDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<ItemCompra>().Wait();
        }

        internal Task<List<ItemCompra>> GetItemsAsync()
        {
            return database.Table<ItemCompra>().ToListAsync();
        }

        public Task<ItemCompra> GetItemAsync(uint id)
        {
            return database.Table<ItemCompra>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<String> GetTotal()
        {
            return database.ExecuteScalarAsync<String>("SELECT SUM(Valor) FROM ItemCompra");
        }

        public Task<String> GetTotalComprado()
        {
            return database.ExecuteScalarAsync<String>("SELECT SUM(Valor) FROM ItemCompra WHERE Comprado = 'True'");
        }

        public Task<int> SaveItemAsync(ItemCompra item)
        {
            if (item.ID == 0)
            {
                return database.InsertAsync(item);
            }

            return database.UpdateAsync(item);
        }

        public Task<int> DeleteItemAsync(ItemCompra item)
        {
            return database.DeleteAsync(item);
        }
    }
}
