using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CosmosDBDataAccess
    {
        private readonly string endPointUrl;
        private readonly string primaryKey;
        private readonly string databaseName;
        private readonly string containerName;
        private CosmosClient cosmosClient;
        private Database database;
        private Container container;

        public CosmosDBDataAccess(string endPointUrl,
                                  string primaryKey,
                                  string databaseName,
                                  string containerName)
        {
            this.endPointUrl = endPointUrl;
            this.primaryKey = primaryKey;
            this.databaseName = databaseName;
            this.containerName = containerName;

            // establishes connection to azure
            cosmosClient = new CosmosClient(this.endPointUrl, this.primaryKey);
            // database house 1 or more container
            database = cosmosClient.GetDatabase(this.databaseName);
            // connect to a specific container or 1 table in NoSQL. This is also the collection in MongoDB
            container = database.GetContainer(this.containerName);
        }

        public async Task<List<T>> LoadRecordsAsync<T>()
        {
            // c is just an alias. We are already connected to the container
            // * is actually good in NoSQL
            string sql = "select * from c";

            QueryDefinition queryDefinition = new QueryDefinition(sql);
            FeedIterator<T> feedIterator = this.container.GetItemQueryIterator<T>(queryDefinition);

            List<T> output = new List<T>();

            while (feedIterator.HasMoreResults)
            {
                FeedResponse<T> currentResultSet = await feedIterator.ReadNextAsync();

                foreach (T item in currentResultSet)
                {
                    output.Add(item);
                }
            }

            return output;
        }

        public async Task<T> LoadRecordByIdAsync<T>(string id)
        {
            // @Id is the parameterized query
            string sql = "select * from c where c.id = @Id";

            QueryDefinition queryDefinition = new QueryDefinition(sql).WithParameter("@Id", id);
            FeedIterator<T> feedIterator = this.container.GetItemQueryIterator<T>(queryDefinition);

            while (feedIterator.HasMoreResults)
            {
                FeedResponse<T> currentResultSet = await feedIterator.ReadNextAsync();

                return currentResultSet.First();
                //foreach (var item in currentResultSet)
                //{
                //    return item;
                //}
            }

            throw new Exception("Item not found");
        }

        public async Task UpsertRecordAsync<T>(T record)
        {
            await this.container.UpsertItemAsync(record);
        }

        public async Task DeleteRecordAsync<T>(string id, string partitionKey)
        {
            await this.container.DeleteItemAsync<T>(id, new PartitionKey(partitionKey));
        }
    }


}
