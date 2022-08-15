using Ecommerce_mvc_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_mvc_app.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>>GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);

    }
}
