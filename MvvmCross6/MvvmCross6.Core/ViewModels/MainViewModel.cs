using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace MvvmCross6.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _text;
        private IMvxCommand _showTextCommand;

        public IMvxCommand ShowTextCommand =>
            _showTextCommand = _showTextCommand ?? new MvxCommand(DoShowTextCommand);

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        private void DoShowTextCommand()
        {
            Text = "Hello MvvmCross!";
        }
    }
}
