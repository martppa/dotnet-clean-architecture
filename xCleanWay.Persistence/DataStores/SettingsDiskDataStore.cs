﻿using System;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.DataStores;

namespace xCleanWay.Persistence.DataStores
{
    public class SettingsDiskDataStore : ISettingsDataStore
    {
        public IObservable<SettingsEntity> GetSettings()
        {
            throw new NotImplementedException();
        }

        public IObservable<object> SetCacheLifeTimeInMillis()
        {
            throw new NotImplementedException();
        }
    }
}