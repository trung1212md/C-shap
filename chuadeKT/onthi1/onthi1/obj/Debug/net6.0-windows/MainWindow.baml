   M S B A M L   `   `   `  ????A  =onthi1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:onthi1onthi1  5   	       onthi1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:onthi1     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? $??5,12,-5,-12q?6   .+?5
   
   ?? $??QUAN LY SAN PHAM??6   $
??Left=?6+   $??	309,9,0,0q?6F   $	??Top=?6Y   ?? 5   
   $??	SO LUONG ??6   $
??Left=?6$   $??
95,110,0,0q?6?   $	??Top=?6S   ?? 5   
   $??	MA LOAI??6   $
??Left=?6'   $??
57,170,0,0q?6B   $	??Top=?6V   ?? 5   
   $??TEN SAN PHAM??6   $
??Left=?6'   $??	82,76,0,0q?6B   $	??Top=?6U   ?? 5   
   $??MA SAN PHAM??6   $
??Left=?6&   $??	79,49,0,0q?6A   $	??Top=?6T   ?? 5   
   -   5         ??Name$ txtmasanpham??5      $
??Left=?6(   $??
185,56,0,0q?6C    ?? TextWrapping$
 Wrap=?6W   $	??Top=?6k   $	??185??6?   ?? 5   
   $
??Left=?6   $??
181,90,0,0q?6-   $
 Wrap=?6A   $	??Top=?6U   $	??185??6m   ?? 5   
   $
??Left=?6   $??184,118,0,0q?6-   $
 Wrap=?6B   $	??Top=?6V   $	??185??6n   ?? 5   
   -   5         ??Name$ btthem??5      $??Thêm??6!   $
??Left=?60   $??
560,77,0,0q?6K   $	??Top=?6_   $??53??6w   6?   ?? 5   
   -   5        $ btxoa??5      $
??Xóa??6    $
??Left=?6.   $??562,110,0,0q?6I   $	??Top=?6^   $??50??6v   ?? 5   
   -   5        $ btthoat??5      $??Thoát??6"   $
??Left=?62   $??
467,80,0,0q?6M   $	??Top=?6a   $??61??6y   ?? 5   
   -   5        $ btsua??5      $??Sửa??6    $
??Left=?6.   $??560,135,0,0q?6I   $	??Top=?6^   $??55??6v   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagird??5      $??	0,218,0,0q?6P      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ma san pham??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *	masanpham+  5      $ Ten san pham??6%    6;   ?? *
tensanpham+  5      $ So luong??6%    67   ?? *	soluong+  5      $ 
Đơn giá??6%    66   ?? *dongia+  5      $ Ma loai??6%    66   ?? *	tenhang+5"      ?? 5#   
   $
??Left=?6   $??184,118,0,0q?6-   $
 Wrap=?6B   $	??Top=?6V   $	??185??6n   ?? 5$   
   $
??Left=?6   $??185,179,0,0q?6-   $
 Wrap=?6B   $	??Top=?6V   $	??185??6n   ?? 5%   
   $??	DON GIA
??6   $
??Left=?6,   $??101,137,0,0q?6G   $	??Top=?6\   ?? 5&   
   $
??Left=?6   $??187,150,0,0q?6-   $
 Wrap=?6B   $	??Top=?6V   $	??185??6n   ?? 5'   
   -   5        $ txtmasanpham1??5'      $
??Left=?6)   $??447,182,0,0q?6D   $
 Wrap=?6Y   $	??Top=?6m   $	??185??6?   5)      5*      