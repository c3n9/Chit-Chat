   M S B A M L   `   `   `  ����C  ?ChitChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ChitChat.AppWindowsChitChat.AppWindows  5   	   (    "ChitChat.AppWindows.ChatRoomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ChitChat.AppWindows     5   	   -   5          � Title$  ChitChat��5   	   $	��450��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ /Resources/chat.ico��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   � $��2��6   .+�5      �� $
��Left=�5      ��5      �� *Topic+ �� StringFormat$ 
Topic: {0}��5      �� 5      -   5         ��Name$ BCLose��5      $��Close��5      
���   �$��2q�5      
�������$��Right=�5!      $��75��5"      5#      � 5%   
   $��1��6   $	��200��5&      .+�5'      �� -   5         ��Name$ LVEmployees��5'      ��5(      �� 5)      .R�5*      �� ��6$   �� *Name+5+      5-      �� 5.      $��Bottom=�6   .+�5/      �� -   5        $ BAddUser��5/      $��Add User��50      
�������
���   �$��2q�54      �� 55      -   5        $ BChangeTopic��55      $��Change Topic��56      
�������
���   �$��2q�5:      �� 5;      -   5        $ BLeave��5;      $��Leave Chatroom��5<      
�������
���   �$��2q�5@      5A      5B      ]� 5C   
   $��2��6   $��2��5D      .+�5E      �� $��:P��6   $��16(�5F      $
��Left=�5G      �� 5H      -   5        $ BSend��5H      $��Right=�5I      $
��Send��5J      $	��100��5L      $��75��5M      $��2q�5N      ���#54b9f7
���   � �� 	IsDefault . 5Q      �� 5R      -   5        	 ��Name$	 	TBMessage��5R      
 �� AcceptsReturn
 .  �� TextWrapping$
 Wrap=�5T      $��16(�5U      $	��100��5V      $ �� HorizontalScrollBarVisibility$
 Auto=�5W       �� 	MaxLength$	 500��5X      5Y      �� 5Z   
   -	   5        $ LVChatMessages��5\      $��1��5Z      $��1��5[      $��Disabled=�5]      ��5^      �� 5_      .R�5`      ��  �� Orientation$ 
Horizontal=�6!   .+�5a      �� ��6$   �� *Date+$ {0:[HH:mm]}���� 5b      $��5,0,0,0q�5c   $   ��5b   $   �� *Employee.Name+5c   $   �� 5d      $
��Wrap=�5e   $   $	��460��5f   $   ��5d   $   �� *	Message+$ : {0}��5f   $   5g      5h      5j      5n      5o      