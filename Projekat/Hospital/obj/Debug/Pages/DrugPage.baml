   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Hospital.PagesHospital.Pages  5          Hospital.Pages.DrugPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Hospital.Pages     5        N� FontSize$  20(�5	       N� Title$ DrugPage��5
      $	��760��6   $
��1460��6%   .��5      � $��	0,0,10,10q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         
IsReadOnly . $
��Left=�6e   $	��375��6�      CanUserDeleteRows . $	��Top=�6�   $	��293��6�   $��	27,86,0,0q�6�   6�   �� 5   
   -   5         ��Name$ label��5      $��Prihvaćeni 
lekovi��6   $
��Left=�6E   $��	35,14,0,0q�6`   $	��Top=�6s   �� 5   
   -   5         ��Name$ 	searchBox��5      $
��Left=�6%   $��33��6@   $	��Top=�6N   $	��170��6f   $��
150,44,0,0q�6r   6�   �� 5   
   -   5         ��Name$ 	addDoctor��5      $��Dodaj novi lek��6$   $
��Left=�6=   $��46��6X   $��337,480,0,0q�6d   $	��Top=�6y   $	��188��6�   6�    � 5   
   -   5          �Name$ 	Drugframe��5      $�� ��6#   $
��Left=�6.   $	��673��6I   $��640,67,-50,0q�6V   $	��Top=�6l   $	��860��6�   	  � NavigationUIVisibility$	 Hidden=�6�     5   
   -   5        $ dataGridAlternativeDrug��5       . $
��Left=�6t   $	��375��6�    . $	��Top=�6�   $	��288��6�   $��
337,86,0,0q�6�   6�   �� 5   
   -   5        $ 	viewChart��5      $��Pogledaj grafikon��6$   $
��Left=�6@   $��46��6[   $��160,480,0,0q�6g   $	��Top=�6|   $	��160��6�   6�   �� 5   
   -   5        $ 
label_Copy��5      $��Lekovi na 
čekanju��6$   $
��Left=�6J   $��
340,14,0,0q�6e   $	��Top=�6y   �� 5   
   -	   5        $ 
searchBox2��5      $
��Left=�6&   $��33��6A   $	��Top=�6O   $	��170��6g   $��
455,44,0,0q�6s   6�   �� 5   
   -
   5        
 ��Name$
 image��5      $
��Left=�6   $��27��6:   $	��Top=�6F   $��26��6^   $��
427,47,0,0q�6i   $)��#/Hospital;component/Data/search.png��6}   �� 5   
   -   5        $
 
image_Copy��5      $
��Left=�6$   $��26��6?   $	��Top=�6K   $��26��6c   $��
122,48,0,0q�6n   $)��#/Hospital;component/Data/search.png��6�   �� 5   
   -   5        $ viewChart_Copy��5      $��	Uredi lek��6)   $
��Left=�6=   $��46��6X   $��160,545,0,0q�6d   $	��Top=�6y   $	��160��6�   6�   �� 5   
   -   5        $ viewChart_Copy1��5      $��Uredi lek na čekanju��6*   $
��Left=�6I   $��46��6d   $��340,545,0,0q�6p   $	��Top=�6�   $	��185��6�   6�   5      5      