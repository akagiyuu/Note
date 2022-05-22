﻿using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Note.Controls;

public sealed class TextEditor : RichEditBox
{
    public string Text
    {
        get
        {
            Document.GetText(TextGetOptions.None, out var Text);
            return Text;
        }

        set => Document.SetText(TextSetOptions.None, value);
    }

    public bool IsModified
    {
        get;
        set;
    }

    public new TabViewItem Parent { get; set; }

    public TextEditor() => Style = (Style)Application.Current.Resources["RichEditBoxStyle"];

    public void Undo() => TextDocument.Undo();

    public void Cut() => TextDocument.Selection.Cut();

    public void Copy() => TextDocument.Selection.Copy();

    //public void Paste( this TabViewItem Tab, int format = 0 )
    //    => Tab.GetTextEditor()
    //          .TextDocument
    //          .Selection
    //          .Paste(format);
}