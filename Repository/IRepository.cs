using GameIndustry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustry.Repository
{
    public interface IRepository
    {
        List<Game> GetAllGames();
    }
}
