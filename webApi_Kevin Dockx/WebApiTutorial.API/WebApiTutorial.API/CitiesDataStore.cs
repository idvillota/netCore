using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTutorial.API.Models;

namespace WebApiTutorial.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 1,
                            Name = "New York City - Point Of Interest 1",
                            Description = "New York City - Point Of Interest 1 - Description"
                        },
                        new PointOfInterestDto
                        {
                            Id = 2,
                            Name = "New York City - Point Of Interest 2",
                            Description = "New York City - Point Of Interest 2 - Description"
                        },
                        new PointOfInterestDto
                        {
                            Id = 3,
                            Name = "New York City - Point Of Interest 3",
                            Description = "New York City - Point Of Interest 3 - Description"
                        }
                    }
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished",
                     PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 1,
                            Name = "Antwerp - Point Of Interest 1",
                            Description = "Antwerp - Point Of Interest 1 - Description"
                        },
                        new PointOfInterestDto
                        {
                            Id = 2,
                            Name = "Antwerp - Point Of Interest 2",
                            Description = "Antwerp - Point Of Interest 2 - Description"
                        },
                        new PointOfInterestDto
                        {
                            Id = 3,
                            Name = "Antwerp - Point Of Interest 3",
                            Description = "Antwerp - Point Of Interest 3 - Description"
                        }
                    }
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower"
                    ,
                     PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 1,
                            Name = "Paris - Point Of Interest 1",
                            Description = "Paris - Point Of Interest 1 - Description"
                        },
                        new PointOfInterestDto
                        {
                            Id = 2,
                            Name = "Paris - Point Of Interest 2",
                            Description = "Paris - Point Of Interest 2 - Description"
                        },
                        new PointOfInterestDto
                        {
                            Id = 3,
                            Name = "Paris - Point Of Interest 3",
                            Description = "Paris - Point Of Interest 3 - Description"
                        }
                    }
                }
            };
        }
    }
}
