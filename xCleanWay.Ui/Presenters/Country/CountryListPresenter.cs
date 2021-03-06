﻿using xCleanWay.Core.Interactors.Country;
using xCleanWay.Ui.Models.Mapper;
using xCleanWay.Ui.Views;

namespace xCleanWay.Ui.Presenters.Country
{
    /// <summary>
    /// This presenter will control any view that renders a list of
    /// countries
    /// </summary>
    public class CountryListPresenter : ICountryListPresenter
    {
        private ICountryListView view;
        private GetCountries getCountries;
        private CountryModelMapper countryModelMapper;

        public CountryListPresenter(GetCountries getCountries, CountryModelMapper countryModelMapper)
        {
            this.getCountries = getCountries;
            this.countryModelMapper = countryModelMapper;
        }
        
        public void Init()
        {
            // Unused
        }

        public void Pause()
        {
            // Unused
        }

        public void Resume()
        {
            // Unused
        }

        public void Finish()
        {
            getCountries.Dispose();
        }

        public void SetView(ICountryListView countryListView)
        {
            view = countryListView;
        }

        public void RequestCountries()
        {
            getCountries.Execute(
                onNext: countries => { view.RenderCountries(countryModelMapper.Transform(countries)); },
                onError: error => view.ShowErrorMessage(error.Message),
                onCompleted: () => { }, parameters: null);
        }
    }
}