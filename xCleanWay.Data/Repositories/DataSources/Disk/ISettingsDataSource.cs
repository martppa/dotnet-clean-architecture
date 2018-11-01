/*
 * Copyright 2018 Humberto Martín Dieppa, Open source project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataSources.Disk
{
    /// <summary>
    /// Settings data store is intended for Settings retrieval
    /// </summary>
    public interface ISettingsDataSource
    {
        IObservable<ISettingsEntity> GetSettings();
    }
}