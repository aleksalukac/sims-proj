   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Hospital.PagesHospital.Pages  5      !    Hospital.Pages.ResourcePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Hospital.Pages     5        N� FontSize$  20(�5	       N� Title$ ResourcePage��5
      $	��795��6   $
��1465��6)    N� WindowWidth$ 0Q�66   .��5      � $��	0,0,30,10q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ resourceDataGrid��5         
IsReadOnly . $
��Left=�6q   $	��283��6�      CanUserDeleteRows . $	��Top=�6�   $	��263��6�   $��
32,102,0,0q�6�   6�   �� 5   
   -   5         ��Name$ label��5      $��	Resursi
��6   $
��Left=�6;   $��	31,55,0,0q�6V   $	��Top=�6i   $��42��6�   $��93��6�   �� 5   
   -   5         ��Name$ 	searchBox��5      $
��Left=�6%   $��34��6@   $	��Top=�6N   $	��166��6f   $��
129,57,0,0q�6r   6�   �� 5   
   -   5        	 ��Name$	 addResource��5      $��Dodaj resurs��6&   $
��Left=�6=   $��50��6X   $��157,410,0,0q�6d   $	��Top=�6y   $	��138��6�   6�     5   
   -   5        $ supplyDataGrid��5       . $
��Left=�6l   $	��284��6�    . $	��Top=�6�   $	��283��6�   $��337,101,0,0q�6�   6�   �� 5   
   -   5        $ 
label_Copy��5      $��Potrošni 
materijal
��6$   $
��Left=�6P   $��
337,35,0,0q�6k   $	��Top=�6   $��61��6�   $	��163��6�   
 J� RenderTransformOrigin$
 0.448,0.119&�6�   �� 5   
   -   5        $ searchBox_Copy��5      $
��Left=�6*   $��34��6E   $	��Top=�6S   $	��165��6k   $��
455,57,0,0q�6w   $
 -1.317,0&�6�   �� 5   
   -   5        $	 	addSupply��5      $��Dodaj materijal��6$   $
��Left=�6>   $��50��6Y   $��337,410,0,0q�6e   $	��Top=�6z   $	��153��6�   6�    � 5   
   -	   5          �Name$ frame��5      $
��Left=�6   $	��527��6:   $��
675,63,0,0q�6G   $	��Top=�6[   $	��695��6s   �� 5   
   -
   5        $	 button��5      $��Pogledaj grafikon��6!   $
��Left=�6=   $	��Top=�6X   $	��170��6p   $��230,540,0,0q�6|   $��45��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.562Q�6$   �� 5       �� Angle$ -0.93Q�6&   T� 5        T� Y$
 0.49Q�6)   5!      5#      �� 5$   
   -   5         ��Name$ image��5$      $
��Left=�6   $��26��6:   $	��Top=�6F   $��26��6^   $��
429,61,0,0q�6i   $)��#/Hospital;component/Data/search.png��6}   �� 5%   
   -   5        $ 
image_Copy��5%      $
��Left=�6$   $��26��6?   $	��Top=�6K   $��26��6c   $��
103,61,0,0q�6n   $)��#/Hospital;component/Data/search.png��6�   �� 5&   
   -   5        $ image_Copy1��5&      $
��Left=�6%   $��26��6@   $	��Top=�6L   $��26��6d   $��
429,61,0,0q�6o   $)��#/Hospital;component/Data/search.png��6�   �� 5'   
   -   5        $	 addResource_Copy��5'      $��Uredi resurs��6+   $
��Left=�6B   $��50��6]   $��157,475,0,0q�6i   $	��Top=�6~   $	��138��6�   6�   �� 5(   
   -   5        $	 addSupply_Copy��5(      $��Uredi materijal��6)   $
��Left=�6C   $��50��6^   $��337,475,0,0q�6j   $	��Top=�6   $	��153��6�   6�   5*      5+      