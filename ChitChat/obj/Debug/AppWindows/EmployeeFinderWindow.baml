   M S B A M L   `   `   `  ����C  ?ChitChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ChitChat.AppWindowsChitChat.AppWindows  5   	   .    (ChitChat.AppWindows.EmployeeFinderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ChitChat.AppWindows     5   	   -   5          � Title$  ChitChat��5   	   $	��450��5	   	   $	��800��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ /Resources/chat.ico��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��10q�6   .+�5      �� $��Departments��6   $��18(�5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ CBAdmin��5      $��Center=�5       d� 	IsChecked$
 TrueY�5      �� 5      $��Admin��6   $��16(�5      $��Center=�5      $��0,0,5,0q�5       5!      �� 5"      $ 
Horizontal=�6   .+�5#      �� -   5        $ CBITHelpdesk��5#      $��Center=�5$      $
 TrueY�5'      �� 5(      $��IT Helpdesk��6   $��16(�5)      $��Center=�5*      $��0,0,5,0q�5+      5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� -   5        $ CBEngineering��5.      $��Center=�5/      $
 TrueY�52      �� 53      $��Engineering��6   $��16(�54      $��Center=�55      $��0,0,5,0q�56      57      �� 58      $ 
Horizontal=�6   .+�59      �� -   5        $ CBSales��59      $��Center=�5:      $
 TrueY�5=      �� 5>      $��Sales��6   $��16(�5?      $��Center=�5@      $��0,0,5,0q�5A      5B      �� 5C      $ 
Horizontal=�6   .+�5D      �� -   5        $ CBMarketing��5D      $��Center=�5E      $
 TrueY�5H      �� 5I      $��	Marketing��6   $��16(�5J      $��Center=�5K      $��0,0,5,0q�5L      5M      5O      ]� 5P   
   $��1��6   $��10q�5Q      .+�5R      � $��0,0,0,10q�6   $	��Top=�5S      .+�5T      �� .+�5U      �� $��Search employee��6    $��18(�5V       �� 5W      -   5         ��Name$ TBSearch��5W      $��16(�5X      5Y      5Z      �� 5[      -   5        	 ��Name$	 BCLose��5[      $��CLose��5\      
���   �$��2q�5_      
�������$	��Top=�5a      $��Right=�5b      5c      �� 5e      -	   5        
 ��Name$
 LVEmployees��5e      $
��auto��5f      ��5h      �� 5i      .R�5j      �� $
��auto��5k   $   ��5j   $   �� *Name+5k   $   5l      ��5n      �� 5o      .R�5p      �  � Orientation$ Vertical=�6$   5q      5s      5t      5u      5v      