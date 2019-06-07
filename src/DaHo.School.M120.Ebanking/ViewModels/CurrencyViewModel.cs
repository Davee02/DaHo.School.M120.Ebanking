using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DaHo.Library.Wpf;
using DaHo.School.M120.Ebanking.Services;
using FixerSharp;

namespace DaHo.School.M120.Ebanking.ViewModels
{
    public class CurrencyViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;
        private string _outputText;
        private const string SOURCE_CURRENCY = Symbols.CHF;

        public List<string> AvailableCurrencies { get; }

        public string SelectedCurrency { get; set; }

        public string InputAmount { get; set; }

        public string OutputText
        {
            get => _outputText;
            set => SetProperty(ref _outputText, value);
        }

        public ICommand CalculateCommand { get; set; }


        public CurrencyViewModel()
        {
            _dialogService = new MessageboxDialogService();
            var currencySymbolProvider = new CurrencySymbolProvider();
            AvailableCurrencies = currencySymbolProvider.GetCurrencySymbols().ToList();

            CalculateCommand = new RelayCommand(async _ => await Calculate(), _ => !string.IsNullOrWhiteSpace(InputAmount) 
                                                                                   && !string.IsNullOrWhiteSpace(SelectedCurrency));
            Fixer.SetApiKey("875a80a645aa801f6197029bb408df67");
        }

        private async Task Calculate()
        {
            var sanitizedInputAmount = InputAmount.Replace(',', '.');
            if (!double.TryParse(sanitizedInputAmount, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-us"), out double doubleAmount))
            {
                _dialogService.ShowWarnDialog("Der eingegebene Wert muss eine Kommazahl sein", "Keine Kommazahl");
                return;
            }

            var convertedValue = await Fixer.ConvertAsync(SOURCE_CURRENCY, SelectedCurrency, doubleAmount, DateTime.Now);
            OutputText = $"{SOURCE_CURRENCY} {Math.Round(doubleAmount, 2)} = {SelectedCurrency} {Math.Round(convertedValue, 2)}";
        }
    }
}
