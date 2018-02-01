﻿using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Miniblog.Core.Repository.MongoDB.Models;
using Miniblog.Core.Repository.MongoDB.Model;
using Microsoft.Extensions.Options;

namespace Miniblog.Core.Repository.MongoDB
{
    public class MongoDBContext
    {
        private readonly MongoDbDatabaseSetting _dbStetting;
        
        protected IMongoClient Client;
        public IMongoDatabase Database { get; set; }

        public MongoDBContext(MongoDbDatabaseSetting dbStetting)
        {
            _dbStetting = dbStetting;

            Client = new MongoClient(_dbStetting.ConnectionString);
            Database = Client.GetDatabase(_dbStetting.Database);
        }

        internal IMongoCollection<UserEntity> UserEntityCollection => Database.GetCollection<UserEntity>("UserEntity");
        internal IMongoCollection<PostEntity> PostEntityCollection => Database.GetCollection<PostEntity>("PostEntity");
        internal IMongoCollection<CategoryEntity> CategorieEntityCollection => Database.GetCollection<CategoryEntity>("CategoryEntity");
        internal IMongoCollection<BlogEntity> BlogEntityCollection => Database.GetCollection<BlogEntity>("BlogEntity");
    }
}