   M S B A M L   `   `   `  ����L  HGestionMedicament, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GestionMedicament.VueYanisGestionMedicament.VueYanis  5   	   1    +GestionMedicament.VueYanis.GstIndividuYanis   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:GestionMedicament.VueYanis     5   	   -   5          � Title$  GstIndividuYanis��5   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�5	   	   
������ .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $��20 �6#   60   �� 5      $	��350 �6#   61   �� 5      6%   �� 5      $	��350 �6#   61   �� 5      $��20 �6#   60    � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      $��20 �6    6.   �� 5      $��30 �6    6.   �� 5      $��40 �6    6.   �� 5      $��40 �6    6.   �� 5      $��40 �6    6.   �� 5      $��50 �6    6.   �� 5      $��30 �6    6.   �� 5      $��40 �6    6.   �� 5       $��60 �6    6.   .+�5"      �� $��0��6   $��1��6"   $��../Images/Logo_GSB.png��62   $
��Left=�6S   6p   	� 5%      -   5        $��3��5&      $��Gestion Médicament��5'      $��Center=�5(      $	��Top=�5)      $��10q�5*      $��0,15,0,0q�5+      $��50��5,      
�������$��18(�5.      $��2��5/   /   	� 51      -   5        $��1��52      $��
Graphiques��53      $��5q�54      $��
0,15,68,10q�55      $��50��56      $��Right=�58      
�������$��18(�5:      �� 5E      
�������$��2��6+   $��1��68    �� TextAlignment$ Center=�6H   $��16(�6_   $%�� Création d'un nouvel individu��6m   �� 5F      
�������$��3��6+   $��1��68   $	��Top=�6H   $��2��6`   $��	10,15,0,0q�6t   $
��Left=�6�   $	��351��6�   $��39��6�   $��2��6�   Type individu �� 5G   
   -   5        $��txtTypeIndividu��5G      $��Center=�6*   $	��240��6E   $��10,0,0,0q�6Q   $��25��6c   6q   6{   	� 5I      -   5         	�Name$ btnCreerMedoc��5I   -   
�������$��1��6D   $��5��6T   $
��Left=�6a   $��
83,10,0,11q�6}   $��1,1,1,1q�6�   .��6�   Créer6�   	� 5J      -   5        $ btnModifier��5J   -   
�������$��1��6B   $��5��6R   $
��Left=�6_   $��243,11,0,10q�6z    J� RenderTransformOrigin$ 	1.45,0.41&�6�   $��72��6�   .��6�   
Modifier6�   �� 5K      
�������$��2��6/   $��3��6<   $ Center=�6L   $��16(�6c   $��31��6q   $��	0,0.4,0,0q�6}   $��2��6�   $	��Top=�6�   $��Les individus��6�   �� 5L      -   5        $��lstTotalTypeIndividu��5L      $��3��62   $��3��6?   $��6��6O   ��5N      �� 5O      .R�5P      ��  �� Orientation$ 
Horizontal=�6%   .+�5Q      �� $	��100��6@   ��6(   �� *IdType+6N   �� 5R      $	��150��6E   ��6(   �� *LibelleType+6S   5S      5T      5V      5W      5X      5Y      