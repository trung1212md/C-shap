   M S B A M L   `   `   `  ????D  @QLSanPham, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLSanPham	QLSanPham  5   	       QLSanPham.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:QLSanPham     5   	   -   5          ? Title$  Quản Lý Sản Phẩm??5   	   $	??450??6"   $	??800??6/   .??5	      ? .+?5
   
   ?? $??Mã Sản Phẩm??6   $
??Left=?6&   $??	40,20,0,0q?6A   $	??Top=?6T   ?? 5   
   $??Tên Sản Phẩm??6   $
??Left=?6'   $??	42,54,0,0q?6B   $	??Top=?6U    J? RenderTransformOrigin$ 	0.5,1.772&?6m   ?? 5   
   $ ??Số Lượng Sản Phẩm??6   $
??Left=?6,   $??	42,88,0,0q?6G   $	??Top=?6Z   $ 	0.5,1.772&?6r   ?? 5   
   $??
Đơn Giá??6   $
??Left=?6"   $??
400,20,0,0q?6=   $	??Top=?6Q   ?? 5   
   $??
Mã Loại??6   $
??Left=?6"   $??
400,54,0,0q?6=   $	??Top=?6Q   ?? 5   
   -   5         ??Name$ txtMa??5      $
??Left=?6!   $??
182,20,0,0q?6<    ?? TextWrapping$
 Wrap=?6P   $?? ??6d   $	??Top=?6l   $	??203??6?   $??29??6?   ?? 5   
   -   5        $ txtTen??5      $
??Left=?6"   $??
182,54,0,0q?6=   $
 Wrap=?6Q   $?? ??6e   $	??Top=?6m   $	??203??6?   $??29??6?   ?? 5   
   -   5        $ 
txtSoLuong??5      $
??Left=?6&   $??
182,88,0,0q?6A   $
 Wrap=?6U   $?? ??6i   $	??Top=?6q   $	??203??6?   $??29??6?   ?? 5   
   -   5        $ 	txtDonGia??5      $
??Left=?6%   $??
475,21,0,0q?6@   $
 Wrap=?6T   $?? ??6h   $	??Top=?6p   $	??203??6?   $??28??6?   ?? 5   
   -   5        $ 	txtMaLoai??5      $
??Left=?6%   $??
475,55,0,0q?6@   $
 Wrap=?6T   $?? ??6h   $	??Top=?6p   $	??203??6?   $??28??6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??GridSP??5      $??42,139,42,0q?5      $	??184??6(   $	??Top=?65      AutoGenerateColumns$ False??5         AlternatingRowBackground
 ?????   
IsReadOnly$
 True??5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Mã??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6H   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   ?? *Ma+6H     5      $
 Tên??6%   $	 * 6J   
 62   ?? *Ten+6J     5      $ Số Lượng??6%   $	 * 6S   
 67   ?? *	SoLuong+6S     5      $ 
Đơn giá??6%   $	 * 6Q   
 66   ?? *DonGia+6Q     5       $ 
Mã Loại??6%   $	 * 6R   
 66   ?? *MaLoai+6R   5"      ?? 5$   
   -   5         ??Name$ btnAdd??5$      $??Thêm??6!   $
??Left=?60   $??108,370,0,0q?6K   $	??Top=?6`   $??36??6x   $??94??6?   6?   ?? 5%   
   -	   5        $ btnDel??5%      $
??Xóa??6!   $
??Left=?6/   $??514,370,0,0q?6J   $	??Top=?6_   $??36??6w   $??94??6?   6?   ?? 5&   
   -
   5        $ btnAlter??5&      $??Sửa??6#   $
??Left=?61   $??306,370,0,0q?6L   $	??Top=?6a   $??36??6y   $??94??6?   $ 
0.181,1.08&?6?   5)      5*      