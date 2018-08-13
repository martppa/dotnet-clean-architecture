﻿using System;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataSource
{
    public interface ICountryDataSource
    {
        IObservable<Collection<CountryEntity>> GetCountries();
        IObservable<CountryEntity> getCountryByISOCode(string isoCode);
    }
}