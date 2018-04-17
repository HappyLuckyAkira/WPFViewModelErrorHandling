using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
//以下参照
//http://blog.okazuki.jp/entry/20110118/1295338167
//https://qiita.com/hiki_neet_p/items/e381c687b0644c0e4978
namespace WpfApp1
{

    class MainWindowViewModel: BindableBase
    {
        private int input;
        private int input2;
        bool hasViewError;
        public bool HasViewError
        {
            get { return hasViewError; }
            set
            {
                SetProperty(ref hasViewError, value);
                SampleCommand.RaiseCanExecuteChanged();
            }
        }

        public MainWindowViewModel()
        {
            this.SampleCommand = new DelegateCommand(
                // Execute
                () =>
                {
                },
                // CanExecute
                () =>
                {
                    return !HasViewError;
                });
        }

    public DelegateCommand SampleCommand { get; private set; }

        public int Input
        {
            get
            {
                return this.input;
            }

            set
            {
                SetProperty(ref input, value);
            }
        }

        public int Input2
        {
            get
            {
                return this.input2;
            }

            set
            {
                SetProperty(ref input2, value);
            }
        }
    }
}