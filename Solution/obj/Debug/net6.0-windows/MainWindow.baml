   M S B A M L   `   `   `  ????F  BFileManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FileManagerFileManager  5   	       FileManager.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FileManager     5   	   -   5          ? Title$  File Manager??5   	   $	??400??6    ? SizeToContent$ Height=?6*    ? 
ResizeMode$ NoResize=?5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	   .??5      ? $??8q?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??auto ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??AUTO ?6   .+?5   
   ?? $??Center=?6   $??2??62   .+?5      ?? $??20(?6   .??6"   Select Folder61   5      ?? 5   
   $??1??6   $??0??6"    ?? Orientation$ 
Horizontal=?62   $??5q?6K   .+?5      ?? -   5         ??Name$ TextBlockFolder??5      $
??auto??61   $??Center=?6>    ?? TextAlignment$ Center=?6[   5      ?? 5   
   $??1??6   $??1??6"   $ 
Horizontal=?62   $??5q?6K   .+?5      ?? -   5        	 ??Name$	 ButtonOpenFolder??5      $	??100??6N   $??Center=?6Z   $??Open Folder??6w   5       ?? 5"   
   $??2??6   $??5q?6"   $??2??6-   $??Center=?6A   .+?5#      ?? -   5        $	 ButtonOrganize??5#      $	??100??6J   $??Center=?6V   $??Organize??6s   5$      ?? 5&   
   -   5        $ TextBlockNotification??5&      $y?Hidden=?63   $??2??6G   $??5q?6T   $??1??6_   $??Files were moved!??6o   5)      5*      