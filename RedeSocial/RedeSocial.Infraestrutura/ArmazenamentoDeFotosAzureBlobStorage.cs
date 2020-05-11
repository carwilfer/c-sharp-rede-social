using System;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;

namespace RedeSocial.Infraestrutura
{

    public class ArmazenamentoDeFotosAzureBlobStorage : IArmazenamentoDeFotos
    {
        const string connectionString = @"DefaultEndpointsProtocol=https;AccountName=aularedesocial;AccountKey=seVNfBtCIdsLZCKYgSlK10/jFItUBS2QWpzgsbWn4/dCHWT/Y7Nam9CYCVfYcHd/HLVCdPYIpH/hXEyXnh5k8Q==;EndpointSuffix=core.windows.net";
        const string containerName = "fotos-do-perfil";

        public async Task<Uri> ArmazenarFotoDePerfil(IFormFile foto)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);

            BlobClient blobClient = containerClient.GetBlobClient(foto.FileName);

            var fotoStream = foto.OpenReadStream();
            await blobClient.UploadAsync(fotoStream, true);
            fotoStream.Close();

            return blobClient.Uri;
        }
    }
}
