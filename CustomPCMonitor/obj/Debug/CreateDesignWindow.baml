   M S B A M L   `   `   `  ����J  FCustomPCMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CustomPCMonitorCustomPCMonitor  5   	   (    "CustomPCMonitor.CreateDesignWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CustomPCMonitor     5   	     � Title$  CreateDesignWindow��5   	   $	��400��5	   	   $	��450��5
   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	   ���	#FF5A5A5A � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   � -   5         �Name$ CustomTitleBar��5      ���#2e2e2e$��25��6<   $	��Top=�6H    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      o� 
������ 
�������$��14(�6?   $��0��6M   $��Center=�6]   �� 5      -   5        $
��🗕��5      $��30��5      $��2��5      
������ 
���������5"   $   Z� �� 5$      $
��🗖��6   $��30��5%      $��3��5&      ���	#00000000���	#FF787878��5(   (   Z� �� 5+      -   5        $	��✕��5+      $��30��5,      $��4��5-      
������ 
���������50   %   Z� 51      �� 52   
   $��	Set Width��6   $
��Left=�6$   $��	10,91,0,0q�6?   $	��Top=�6R   $��24(�6j   
������ $��Cascadia Code SemiBold)�6�   
�������6�   �� 53   
   -   5         ��Name$ widthTextBox��53      $
��Left=�54   
   $��
10,133,0,0q�55   
    �� TextWrapping$
 Wrap=�56   
   $	��400��57   
   $	��Top=�58   
   $	��200��59   
   $��37��5:   
   $��24(�5;   
   ���	#FF2E2E2E
�������$��Cascadia Code SemiBold)�5?   
   ��5>   
   Z� 5B   
   �� 5C   
   $��
Set Height��6   $
��Left=�6%   $��
10,191,0,0q�6@   $	��Top=�6T   $��24(�6l   
������ $��Cascadia Code SemiBold)�6�   
�������6�   �� 5D   
   -   5        $��heightTextBox��5Q      $
��Left=�5D      $��
10,234,0,0q�5E      $
 Wrap=�5F      $	��300��5G      $	��Top=�5H      $	��200��5I      $��36��5J      $��24(�5K      ���	#FF2E2E2E
�������$��Cascadia Code SemiBold)�5O      ��5N      Z� 5S      �� 5T   
   $��Choose Device��6   $
��Left=�6(   $��
10,291,0,0q�6C   $	��Top=�6W   $��24(�6o   
������ $��Cascadia Code SemiBold)�6�   
�������6�   �� 5U   
   $(��"Choose a Resolution for the Window��6   $
��Left=�6=   $��	10,30,0,0q�6X   $	��Top=�6k   $��20(�6�   
������ $��Cascadia Code SemiBold)�6�   
�������6�   �� 5V   
   
�������$��1q�6%   $��0,25,0,0q�69    K� ZIndex$ -1��6K   ._�5W      �� $��9,310,241,28q�5X      ���	#FF2E2E2E
�������$��Cascadia Code SemiBold)�5Z   @   ��6)   Z� 6@   5[      �� 5\   
   -   5        	 ��Name$	 StartBorder��5`      
�������$��1q�5]      $��290,176,50,176q�5^      
 �� CornerRadius$
 5��5_      ��5b      �� 5c       �� 
TargetType" ��6   .�5d      ��  �� Property � �� �� Value
 ���� 63    �� Triggers 5e      P� 5f       P� Property �@J�IsMouseOver P� Value . . �5g      ��  � �� �	#FF2E2E2E6;   5h      5j      ._�5l      �� $��Start��6   $��Center=�6$   $��Center=�6?   $��24(�6\   
�������$��Cascadia Code SemiBold)�6}   5m      5p      5q      