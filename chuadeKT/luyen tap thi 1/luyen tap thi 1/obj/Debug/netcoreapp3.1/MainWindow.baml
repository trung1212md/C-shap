   M S B A M L   `   `   `  ????J  Fluyen tap thi 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:luyen_tap_thi_1luyen_tap_thi_1  5   	        luyen_tap_thi_1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:luyen_tap_thi_1     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? $??	0,0,0,-55q?6    ? ColumnDefinitions 5
   
   ?? 5      $	??27* ?6   ?? 5      $	??23* ?6   .+?5   
   ?? $??Ma sản pham??6   $
??Left=?6&   $??	48,36,0,0q?6A   $	??Top=?6T   ?? 5   
   $??Ten sản phẩm??6   $
??Left=?6'   $??	48,72,0,0q?6B   $	??Top=?6U   ?? 5   
   $??Số lượng??6   $
??Left=?6#   $??
64,109,0,0q?6>   $	??Top=?6R   ?? 5   
   $??
Đơn giá??6   $
??Left=?6"   $??
63,159,0,0q?6=   $	??Top=?6Q   ?? 5   
   $??
Mã loại??6   $
??Left=?6"   $??
69,194,0,0q?6=   $	??Top=?6Q   ?? 5   
   -   5         ??Name$ 	txtdongia??5      $
??Left=?6%   $??145,160,0,0q?6@    ?? TextWrapping$
 Wrap=?6U   $	??Top=?6i   $	??382??6?   $??2??6?   ?? 5   
   -   5        $ txtmasp??5      $
??Left=?6#   $??
146,41,0,0q?6>   $
 Wrap=?6R   $	??Top=?6f   $	??380??6~   $??2??6?   ?? 5   
   -   5        $ 	txtmaloai??5      $
??Left=?6%   $??143,197,0,0q?6@   $
 Wrap=?6U   $	??Top=?6i   $	??382??6?   $??2??6?   ?? 5   
   -   5        $ 
txtsoluong??5      $
??Left=?6&   $??145,121,0,0q?6A   $
 Wrap=?6V   $	??Top=?6j   $	??380??6?   $??2??6?   ?? 5   
   -   5        $ txttensp??5      $
??Left=?6$   $??
144,79,0,0q?6?   $
 Wrap=?6S   $	??Top=?6g   $	??381??6    J? RenderTransformOrigin$ 0.5,0.5&?6?   $??2??6?   .??6?   z?5      V? 5      .~?5      ?? ?? 5      ?? 5       ?? Angle$ 0.003Q?6&   T? 5      5      .??5   '   5       &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ datagrid??5!      $??0,234,0,102q?6%   $??2??6:      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm ??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 120 6T   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   ?? *masp+6T     5$      $ Tên sản phẩm ??6%   $		 120 6V   
 6<   ?? *tensp+6V     5%      $ So lượng??6%   $		 120 6S   
 67   ?? *	soluong+6S     5&      $ 
Đơn giá??6%   $		 120 6Q   
 66   ?? *dongia+6Q     5'      $ Tên loại sản phẩm ??6%   $	 * 6]   
 6A   ?? *	tenloai+6]   5*      ?? 5+   
   -   5         ??Name$ btthem??5+      $??Thêm??6!   $
??Left=?60   $??177,403,0,0q?6K   $??62??6`   $??20??6?   $	??Top=?6?   ?? 5,   
   -	   5        $ btsua??5,      $??Sửa??6    $
??Left=?6.   $??312,409,0,0q?6I   $	??Top=?6^   $??53??6v   6?   ?? 5-   
   -
   5        $ btxoa??5-      $
??Xóa??6    $
??Left=?6.   $??
41,411,0,0q?6I   $	??Top=?6]   $??1??6u   $??55??6?   6?   ?? 5.   
   -   5        $ btthoat??5.      $??Thoát??6"   $
??Left=?62   $??186,410,0,0q?6M   $	??Top=?6b   $??1??6z   $??53??6?   6?   50      51      