   M S B A M L   `   `   `  ????B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? $??Mã Bệnh Nhân??6   $
??Left=?6'   $??	57,36,0,0q?6B   $	??Top=?6U   ?? 5   
   $??	Họ Tên??6   $
??Left=?6!   $??	92,68,0,0q?6<   $	??Top=?6O   ?? 5   
   $??Địa chỉ??6   $
??Left=?6"   $??	91,97,0,0q?6=   $	??Top=?6P   ?? 5   
   $??Số ngày năm viện??6   $
??Left=?6+   $??
52,132,0,0q?6F   $	??Top=?6Z   ?? 5   
   $??
Khoa Khám??6   $
??Left=?6$   $??
81,160,0,0q?6?   $	??Top=?6S   ?? 5   
   -   5         ??Name$
 mabn??5      $
??Left=?6    $??
175,33,0,0q?6;    ?? TextWrapping$
 Wrap=?6O   $	??Top=?6c   $	??262??6{   ?? 5   
   -   5        $ hoten??5      $
??Left=?6!   $??
172,72,0,0q?6<   $
 Wrap=?6P   $	??Top=?6d   $	??262??6|   ?? 5   
   -   5        $ diachi??5      $
??Left=?6"   $??174,100,0,0q?6=   $
 Wrap=?6R   $	??Top=?6f   $	??262??6~   ?? 5   
   -   5        $ songaynv??5      $
??Left=?6$   $??172,136,0,0q?6?   $
 Wrap=?6T   $	??Top=?6h   $	??262??6?   ?? 5   
   -   5         ??Name$
 khoa??5      $
??Left=?6!   $??175,165,0,0q?6<   $	??Top=?6Q   $	??262??6i   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ listBN??5      $??
0,212,0,70q?6#      AutoGenerateColumns$ False??67      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 MaBN??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *MaBn+  5      $ 	Họ Tên??6%    65   ?? *HoTen+  5      $ Mã Khoa??6%    66   ?? *MaKhoa+  5      $ Địa chỉ??6%    66   ?? *DiaChi+  5      $ Số Ngày nằm Viện??6%    6?   ?? *SoNgayNamVien+  5      $ Viện Phí??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6S    67   ?? *	VienPhi+6S   5      ?? 5   
   -   5        $??Thêm??5      $
??Left=?6    $??
21,382,0,0q?6;   $	??Top=?6O   $??74??6g   $??27??6r   6~   ?? 5    
   -	   5        $??Sửa??5       $
??Left=?6   $??181,381,0,0q?6:   $	??Top=?6O   $??76??6g   $??27??6r   6~   ?? 5!   
   -
   5        $
??Xóa??5!      $
??Left=?6   $??344,382,0,0q?6:   $	??Top=?6O   $??78??6g   $??27??6r   6~   ?? 5"   
   $
??Tìm??6   $
??Left=?6   $??516,382,0,0q?6:   $	??Top=?6O   $??62??6g   $??27??6r   ?? 5#   
   $??Thống kê??6   $
??Left=?6$   $??683,382,0,0q?6?   $	??Top=?6T   $??56??6l   $??27??6w   5%      5&      