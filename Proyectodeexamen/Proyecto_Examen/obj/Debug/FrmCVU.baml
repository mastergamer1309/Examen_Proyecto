   M S B A M L   `   `   `  ����J  FProyecto_Examen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Proyecto_ExamenProyecto_Examen  5   	       Proyecto_Examen.FrmCVU   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Proyecto_Examen     5   	     � Title$  FrmCVU��5   	   $	��450��6   $	��800��6%   .��5	      � ���	#FF6CC5BA � ColumnDefinitions 5
   
   �� 5      $
��121* �6   �� 5      $
��679* �6   .+�5   
   �� -   5         ��Name$ lblPrecioDeVentaPorUnidad��5      $!��Precio  de venta por unidad��63   $
��Left=�6Y   $��	10,51,0,0q�6t   $	��Top=�6�   $��18(�6�   $��2��6�   �� 5   
   -   5        $ LblCostoVariablePorUnidad��5      $��Costo Variable por unidad��63   $
��Left=�6W   $��	10,82,0,0q�6r   $	��Top=�6�   $��18(�6�   $��2��6�   �� 5   
   -   5        $ LblCostosFijosTotales��5      $��Costos fijos Totales��6/   $
��Left=�6N   $��
10,113,0,0q�6i   $	��Top=�6}   $��18(�6�   $��2��6�   �� 5   
   -   5         ��Name$ TxtPrecioDeVentaPorUnidad��5      $
��Left=�65   $��
159,59,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   $��1��6�   �� 5   
   -   5        $ TxtCostoVariablePorUnidad��5      $
��Left=�65   $��
159,90,0,0q�6P   $
 Wrap=�6d   $��
��6x   $	��Top=�6�   $	��120��6�   $��18��6�   $��1��6�   �� 5   
   -   5        $ TxtCostosFijosTotales��5      $
��Left=�61   $��159,121,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $��1��6�   �� 5   
   -   5        $ LblDatos��5      $��Datos��6"   $
��Left=�62   $��	10,20,0,0q�6M   $	��Top=�6`   $��24(�6x   �� 5   
   -   5        $ LblCalculos��5      $��Calculos��6%   $��Center=�68   $��	0,156,0,0q�6U   $	��Top=�6h   $��24(�6�   �� 5   
   -	   5        $&  LblMargenDeContribucionPorUnidad��5      $'��!Margen de contribucion por unidad��6:   $
��Left=�6f   $��Center=�6�   $��18(�6�   $��2��6�   �� 5   
   -
   5        $&  TxtMargenDeContribucionPorUnidad��5      $
��Left=�6<   $��	191,0,0,0q�6W   $
 Wrap=�6j   $��Center=�6~   $	��120��6�   {�.  $��1��6�   �� 5   
   -   5        $$ LblPuntoDeEquilibrioEnUnidades��5      $%��Punto de Equilibrio en unidades��68   $
��Left=�6b   $��	0,258,0,0q�6}   $	��Top=�6�   $��18(�6�   $��2��6�   �� 5   
   -   5        $$ TxtPuntoDeEquilibrioEnUnidades��5      $
��Left=�6:   $��191,262,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   {�.  $��1��6�   �� 5   
   -   5        $" LblPuntoDeEquilibrioEnVentas��5      $"��Punto de Equlibrio en Ventas��66   $
��Left=�6]   $��
10,312,0,0q�6x   $	��Top=�6�   $	��260��6�   $��18(�6�   $��2��6�   �� 5   
   -   5        $" TxtPuntoDeEquilibrioEnVentas��5      $
��Left=�68   $��191,320,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   {�.  $��1��6�   �� 5   
   -   5         ��Name$ BtnCalcular��5      $��Calcular��6&   $
��Left=�69   $��384,155,0,0q�6T   $	��Top=�6i   $��62��6�   $	��212��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��1��6�   z�5      V� 5      .~�5      �� �� 5       �� 5!       �� Angle$ -0.09Q�6&   T� 5"      5#      5%      �� 5&   
   -   5        $��1��5&      $��Volver Al Menu��6!   $
��Left=�6:   $��
480,10,0,0q�6U   $	��Top=�6i   $��20(�6�   $��Arial Black)�6�   6�   5(      5)      