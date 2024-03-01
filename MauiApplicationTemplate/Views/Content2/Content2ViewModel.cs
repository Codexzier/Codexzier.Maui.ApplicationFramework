using Codexzier.Maui.ApplicationFramework.Views.Base;

namespace MauiApplicationTemplate.Views.Content2;

internal class Content2ViewModel : BaseViewModel
{
    private bool _optionIsSet01;
    private bool _optionIsSet02;
    private string _labelResultOption = "Dies ist ein Test";
    private string _editorText;

    public bool OptionIsSet01
    {
        get => _optionIsSet01;
        set
        {
            _optionIsSet01 = value;
            this.OnNotifyPropertyChanged(nameof(this.OptionIsSet01));
        }
    }

    public bool OptionIsSet02
    {
        get => _optionIsSet02;
        set
        {
            _optionIsSet02 = value;
            this.OnNotifyPropertyChanged(nameof(this.OptionIsSet02));
        }
    }

    public string LabelResultOption
    {
        get => _labelResultOption;
        set
        {
            _labelResultOption = value;
            this.OnNotifyPropertyChanged(nameof(this.LabelResultOption));
        }
    }

    public string EditorText
    {
        get => this._editorText;
        set
        {
            this._editorText = value;
            this.OnNotifyPropertyChanged(nameof(this.EditorText));
        }
    }
}