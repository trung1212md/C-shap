   M S B A M L   `   `   `  ????B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? $??Mã Bệnh Nhân??6   $
??Left=?6'   $??48,6,0,0q?6B   $	??Top=?6T   $??29??6l   ?? 5   
   $??	Họ Tên??6   $
??Left=?6!   $??	83,47,0,0q?6<   $	??Top=?6O   $??29??6g   ?? 5   
   $??Địa Chỉ??6   $
??Left=?6"   $??	82,86,0,0q?6=   $	??Top=?6P   $??29??6h   ?? 5   
   $??Số ngày nằm viện??6   $
??Left=?6+   $??
31,124,0,0q?6F   $	??Top=?6Z   $??29??6r   ?? 5   
   $??
Khoa khám??6   $
??Left=?6$   $??
61,156,0,0q?6?   $	??Top=?6S   $??33??6k   ?? 5   
   -   5         ??Name$
 mabn??5      $
??Left=?6    $??
148,15,0,0q?6;    ?? TextWrapping$
 Wrap=?6O   $	??Top=?6c   $	??205??6{   ?? 5   
   -   5        $ hoten??5      $
??Left=?6!   $??
151,53,0,0q?6<   $
 Wrap=?6P   $	??Top=?6d   $	??205??6|   ?? 5   
   -   5        $ diachi??5      $
??Left=?6"   $??
152,91,0,0q?6=   $
 Wrap=?6Q   $	??Top=?6e   $	??205??6}   ?? 5   
   -   5        $ songaynv??5      $
??Left=?6$   $??151,128,0,0q?6?   $
 Wrap=?6T   $	??Top=?6h   $	??205??6?   ?? 5   
   -   5         ??Name$
 khoa??5      $
??Left=?6!   $??152,160,0,0q?6<   $	??Top=?6Q   $	??204??6i   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ listBN??5      $??2,197,-2,75q?6#      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 MaBN??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *MaBn+  5      $ 	Họ Tên??6%    65   ?? *HoTen+  5      $ Ma Khoa??6%    66   ?? *MaKhoa+  5      $ Dia chi??6%    66   ?? *DiaChi+  5      $ 
So Ngay NV??6%    69   ?? *SoNgayNamVien+  5      $ Viện Phí??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S    67   ?? *	VienPhi+6S   5      ?? 5   
   -   5        $
??Them??5      $
??Left=?6    $??
64,376,0,0q?6;   $	??Top=?6O   $??28??6g   $??80??6s   6~   ?? 5    
   -	   5        $	??Sua??5       $
??Left=?6   $??201,378,0,0q?6:   $	??Top=?6O   $??28??6g   $??73??6s   6~   ?? 5!   
   -
   5        $	??Xoa??5!      $
??Left=?6   $??354,377,0,0q?6:   $	??Top=?6O   $??29??6g   $??68??6s   6~   ?? 5"   
   -   5        $	??Tim??5"      $
??Left=?6   $??506,380,0,0q?6:   $	??Top=?6O   $??30??6g   $??66??6s   6~   ?? 5#   
   -   5        $??Thống Kê??5#      $
??Left=?6$   $??657,379,0,0q?6?   $	??Top=?6T   $??30??6l   $??68??6x   6?   5%      5&      