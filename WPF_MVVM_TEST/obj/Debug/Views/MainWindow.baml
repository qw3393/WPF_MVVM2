   M S B A M L   `   `   `  ????H  DWPF_MVVM_TEST, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WPF_MVVM_TEST.ViewModelWPF_MVVM_TEST.ViewModel  5   	   -clr-namespace:WPF_MVVM_TESTWPF_MVVM_TEST  5   	       WPF_MVVM_TEST.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4vm%clr-namespace:WPF_MVVM_TEST.ViewModel     5   	   -localclr-namespace:WPF_MVVM_TEST     5   	     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)    ? DataContext 5
      8   2WPF_MVVM_TEST.ViewModel.CurrencyConverterViewModel  5   
   .??5      ? .+?5   
   ?? $
??Left=?6   $??
107,80,0,0q?6/   $
??Wrap=?6C   $??Curency??6W   $	??Top=?6f   ?? 5   
   $
??Left=?6   $??107,110,0,0q?6/   $
??Wrap=?6D   $??Amount in €??6X   $	??Top=?6k   ?? 5   
   $
??Left=?60   $??107,140,0,0q?6K   $
??Wrap=?6`   $	??Top=?6t   ??6   ?? *
ResultText+6t   ?? 5   
   $
??Left=?6/   $??260,140,0,0q?6J   $
??Wrap=?6_   $	??Top=?6s   ??6   ?? *	Converted+6s   ?? 5   
   $
??Left=?6   $??
260,80,0,0q?6.   $	??Top=?6B   $	??120??6Z    ?? SelectedItem 5      ?? *SelectedCurrency+??5      ?? *
Currencies+??5      ?? 5      .R?5      ?? ??6    ?? *Title+5      5      ?? 5   
   $
??Left=?6)   $??16??6D   $??260,110,0,0q?6P    ?? TextWrapping$
 Wrap=?6e   $	??Top=?6y   $	??107??6?   ??6   ?? *Euros+6?   5      5      