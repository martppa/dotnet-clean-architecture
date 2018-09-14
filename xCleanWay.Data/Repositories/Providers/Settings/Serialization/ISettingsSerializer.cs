﻿using xCleanWay.Data.Repositories.Providers.RawModels;

namespace xCleanWay.Data.Repositories.Providers.Settings.Serialization
{
    public interface ISettingsSerializer
    {
        RawSettings GetSettings();
        void WriteSettings(RawSettings rawSettings);
    }
}