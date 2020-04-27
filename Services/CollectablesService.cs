using System.Collections.Generic;
using System.Threading.Tasks;
using Banjo_kazooie_api.Helpers;
using Banjo_kazooie_api.Models;
using Banjo_kazooie_api.Services.Interfaces;
using Microsoft.Extensions.Options;

namespace Banjo_kazooie_api.Services
{
    public class CollectablesService : ICollectablesService
    {
        private readonly FilePaths filePaths;
        public CollectablesService(IOptions<FilePaths> filePaths)
        {
            this.filePaths = filePaths.Value;
        }

        public async Task<List<Collectable>> GetCollectables()
        {
            var content = await RepositoryParser.ParseRepository<List<Collectable>>(filePaths.Collectables);
            return content;
        }
    }
}