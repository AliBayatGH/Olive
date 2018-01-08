﻿using System.Threading.Tasks;
using Olive.Entities;

namespace Olive.Services.BlobAws
{
    public class S3BlobStorageProvider : IBlobStorageProvider
    {
        public Task SaveAsync(Blob document) => S3Proxy.Upload(document);

        public Task DeleteAsync(Blob document) => S3Proxy.Delete(document);

        public Task<byte[]> LoadAsync(Blob document) => S3Proxy.Load(document);

        public Task<bool> FileExistsAsync(Blob document) => S3Proxy.FileExists(document);

        public bool CostsToCheckExistence() => true;
    }
}