using DomainData;
using DomainRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainService
{
    public interface IMovieService : IRepository<Movie>
    {
    }
}
