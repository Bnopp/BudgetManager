   M S B A M L   `   `   `  ????H  DBudgetManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BudgetManager.WindowsBudgetManager.Windows  5   	   0    *BudgetManager.Windows.DeleteCategoryWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:BudgetManager.Windows     5   	     ? Title$  Delete Category??5   	   $	??150??6!   $	??400??6.      MainBackgroundColor#???   5	   	    ? WindowStyle$ 
ToolWindow=?5
   	    ? 	Resources 5       ?? 
TargetType ?? Property  MainTextColor ?? Value  
MainButton ?? BasedOn??%?   '??       7  '?? ?     7  ?? 5   
   " ??6   .?5      ??  ? ??8   6+   ?? 5       ? ??$
 Bold"?6+   ?? 5       ? ??$ 20(?6)   ?? 5       ? ??$ 
10,10,10,0q?6'   5      ?? 5   
   " ??6   8   6$   5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5        $??cbCats??5        ComboBoxRoundedCornersStyle#???  6!   $??	10,0,10,0q?6W   $??0??6j   ?? 5   
   -   5        $??Delete??5      $??Center=?6"   $??90??6?   $??35??6J   $??1??6V   6c   5      5      