﻿namespace TraditionalWebAPI.Services
{
    using System.Collections.Generic;
    using Models;
    using TraditionalWebAPI.Repositories;

    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository;
        }

        public IEnumerable<Director> ListAllDirectors()
        {
            return this.directorRepository.ListAllDirectors();
        }

        public Director ListDirectorById(int id)
        {
            return this.directorRepository.ListDirectorById(id);
        }
    }
}
