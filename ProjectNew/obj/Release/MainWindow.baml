   M S B A M L   `   `   `  ���� E  AProjectNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectNew
ProjectNew  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem     ProjectNew.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:ProjectNew     6sys&clr-namespace:System;assembly=mscorlib       � Title$  
MainWindow��$��478.333��$��636.667��$y�Visible=� � WindowStyle$
 None=� � AllowsTransparency . 
������ 
������ .��� 
������ $��10,31,54,20q� � RowDefinitions �� $
��222* ��� $
��205* � � ColumnDefinitions �� $	��47* ��� $
��409* ��� $��0* �.+��� -   $
��Left=�$	��408��$	��Top=�$	��513�� �� RadiusY$ 15�����	#FF0D0E0D$��0�� �� RadiusX$ 15�� J� Opacity$
 0.85Q�$��1�� J� RenderTransformOrigin$ 0.5,0.5&����	#FFF9F9F9$��2��	 J� OpacityMask	 �� 
 �� EndPoint$
 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$	 0.5Q�� $ 	#FF97CD8B��$ 1Q��� -    ��Name$ TitleBar��$
��Left=�$��25�����	#FF0D0E0D$��0��$	��Top=�$	��513��$��1������ $
 0.5,1&�$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ 	#FFEEF9E8��� $ 	#FFA9C550��$ 0.931Q��� -    ��Name$ buttonMinimize��$��Button��$��1��$
��Left=�$��0,30,0,0q�$	��Top=�$��32��$��37��$ 0.527,0.127&����� .R���  ��Name$ 	theBorder��
������ $��1q�._��� $��Resorces/min.png��$��45�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ 	theBorder�� �� Property � �� �� Value �	#FFF9F5F5�� -   $ 
buttonExit��$��Button��$��1��$
��Left=�$��
472,25,0,0q�$	��Top=�$��32��$��37��$ -5.058,-5.403&����� .R��� $ 	theBorder��
������ $��1q�._��� $��Resorces/wp.png��$��45�� P�  �@J�IsMouseOver . . ��� $ 	theBorder�� � �� �	#FFF9F5F5�� -    ��Name$ DateBox��$
��Left=�$��20��$��399,10,-10,0q�$��2016-06-21  ��$	��Top=�$	��125��$��1��$	 0.8Q�$
��Bold"�
������ 
�������$ 0.714,4.921&�$��2���� -    ��Name$ label��$��1��$��Right=�$	��382��$��	0,30,91,0q�$	��Top=�$	��353��$	 0.5Q�$ 0.5,0.5&�$��6q�$��2������  �� Color$ 	#FF6E6E6E�� �� Opacity$	 0.2Q����� $
 0.5,1&�$ 0.5,0&�.��� $ 	#FFE2DDDD��$
 0.73Q�� $ White��$ 0.004Q�� $ 	#FFFEFEFE���� -   $ button1��$��1��$��70,121,374,20q�$��1��$��0q�|�.  ���� .R��� $ 	theBorder��
������ $��1q�._��� $��Resorces/registerr.png��$��45�� P�  �@J�IsMouseOver . . ��� $ 	theBorder�� Z�  � ������  �� ImageSource$ Resorces/registerr.png���� $��135,160,193,33.833q�$��1��$��3q����	#FFF9F9F9$��Bradley Hand ITC)� �� AcceptsReturn . $��20(�$	 0.8Q� �� SelectionBrush
 �   �.������ $
 0.5,1&�$ 0.5,0&�.��� $ 	#FFE8EEE9��$ 0Q�� $ 	#FF969C8B��$ 1Q�.������ $
 0.5,1&�$ 0.5,0&�.��� $ 	#FFF8F9F7��$ 0Q�� $ 	#FF7A7E78��$ 1Q�.���� $��135,13.167,193,164q�$��1��$��3q����	#FFF9F9F9$��Bradley Hand ITC)� . $��20(�$	 0.8Q�
 �   �$��1��.������ $
 0.5,1&�$ 0.5,0&�.��� $ 	#FFE8EEE9��$ 0Q�� $ 	#FF969C8B��$ 1Q�.������ $
 0.5,1&�$ 0.5,0&�.��� $ 	#FFF8F9F7��$ 0Q�� $ 	#FF7A7E78��$ 1Q�.���� -   $ 
textBlock1��$��1��$
��Left=�$��73��$��
135,53,0,0q�$
��Wrap=�$	��Top=�$	��189�����	#FFA6B898$��Brush Script MT)�$
��Bold"�$��57.333(�$��Italic$�$ 0.605,0.902&��� $�Log In���� �� �� -	   $ 	textBlock��$��	User Name��$��1��$
��Left=�$��135,193,0,0q�$
��Wrap=�$	��Top=�$	��186��$��26�����	#FF746F6F$��16(�$��Italic$�$��Tempus Sans ITC)��� -
   $ 
textBlock2��$��	Pass Word��$��1��$
��Left=�$��135,46.167,0,0q�$
��Wrap=�$	��Top=�$	��186��$��26�����	#FF746F6F$��16(�$��Italic$�$��Tempus Sans ITC)�$��1���� -   $ button��$��1��$
��Left=�$��65��$��
347,0,0,20q�$��Bottom=�$��76��$��0q�$��1��$ 0.972,-0.003&����� .R��� $ 	theBorder��
������ $��1q�._��� $��Resorces/log new.png��$��45�� P�  �@J�IsMouseOver . . ��� $ 	theBorder�� Z�  � ������ $ Resorces/log new.png��