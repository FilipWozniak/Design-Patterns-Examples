   M S B A M L   `   `   `  ����Z  VChainofResponsibilityCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ChainofResponsibilityCalculatorChainofResponsibilityCalculator  5   	   0    *ChainofResponsibilityCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ChainofResponsibilityCalculator     5   	     � Title$(  "Chain of Responsibility Calculator��5   	   $	��180��64   $	��500��6A    � 
ResizeMode$ NoResize=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��161* �6   �� 5      $
��331* �6   .+�5   
   �� -   5         ��Name$ NumberOneField��5      $
��Left=�6+   $��24��6F   $��	10,32,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��122��6�   6�   �� 5   
   -   5        $ NumberTwoField��5      $
��Left=�6*   $��24��6E   $��0,32,0,0q�6Q   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��136��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $	��Add��6$   $
��Left=�62   $��	10,92,0,0q�6M   $	��Top=�6`   $��75��6x   6�   �� 5   
   -   5        $ SubstractButton��5      $��	Substract��6*   $
��Left=�6>   $��	98,92,0,0q�6Y   $	��Top=�6l   $��74��6�   $��2��6�   6�   �� 5   
   -   5        $ MultiplyButton��5      $��Multiply��6)   $
��Left=�6<   $��	23,92,0,0q�6W   $	��Top=�6j   $��74��6�   $��1��6�   6�   �� 5   
   -   5        $ DivideButton��5      $��Divide��6'   $
��Left=�68   $��
111,92,0,0q�6S   $	��Top=�6g   $��76��6   $��1��6�   6�   �� 5   
   -   5         ��Name$ Result��5      $��1��6$   $
��Left=�64   $��
201,33,0,0q�6O   $
��Wrap=�6c   $��Result: ��6w   $	��Top=�6�   �� 5   
   $
��Left=�6   $��	40,10,0,0q�6/   $
��Wrap=�6B   $��
Number One��6V   $	��Top=�6h   �� 5   
   $
��Left=�6   $��	38,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��1��6n   �� 6   $�Number ��6�   �� 6�   $	�Two��6�   6�   5      5      